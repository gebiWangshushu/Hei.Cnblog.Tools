using System;
using System.IO;
using System.Text;
using CnBlogPublishTool.Util;
using MetaWeblogClient;
using Newtonsoft.Json;
using Polly;

namespace CnBlogPublishTool
{
    public class ImageUploader
    {
        public static Client BlogClient;

        public static void Init(BlogConnectionInfo info)
        {
            BlogClient = new Client(info);
        }

        public static void Init(string path, byte[] teaKey)
        {
            var info = JsonConvert.DeserializeObject<BlogConnectionInfo>(File.ReadAllText(path));
            info.Password = Encoding.UTF8.GetString(TeaHelper.Decrypt(Convert.FromBase64String(info.Password), teaKey));
            BlogClient = new Client(info);
        }

        public static string Upload(string filePath)
        {
            var policy = Policy.Handle<Exception>().Retry(3, (exception, retryCount) =>
             {
                 Console.WriteLine("上传失败，正在重试 {0}，异常：{1}", retryCount, exception.Message);
             });
            try
            {
                var url = policy.Execute<string>(() =>
                {
                    FileInfo fileinfo = new FileInfo(filePath);
                    var mediaObjectInfo = BlogClient.NewMediaObject(fileinfo.Name, MimeMapping.GetMimeMapping(filePath), File.ReadAllBytes(filePath));
                    return mediaObjectInfo.URL;
                });

                return url;
            }
            catch (Exception e)
            {
                throw new Exception($"上传失败,异常：{e.Message}");
            }
        }
    }
}