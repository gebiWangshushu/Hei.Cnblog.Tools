using CnBlogPublishTool;
using CnBlogPublishTool.Util;
using MetaWeblogClient;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hei.Cnblog.Tools
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            if (File.Exists(Const.CnblogSettingPath))
            {
                var config = JsonConvert.DeserializeObject<BlogConnectionInfo>(File.ReadAllText(Const.Appsettings));
                this.textBlogid.Text = config.BlogID;
                this.textBlogid.Text = config.Username;
            }
        }

        private void btnComfirm_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(this.textBlogid.Text)
                || string.IsNullOrWhiteSpace(this.textUserName.Text)
                || string.IsNullOrWhiteSpace(this.textPassword.Text))
            {
                MessageBox.Show("博客园id，用户名密码均不能为空！");
                return;
            }

            var connInfo = new BlogConnectionInfo(
              "https://www.cnblogs.com/" + this.textBlogid.Text,
              "https://rpc.cnblogs.com/metaweblog/" + this.textBlogid.Text,
              this.textBlogid.Text,
              this.textUserName.Text,
              this.textPassword.Text
            );

            ImageUploader.Init(connInfo);
            connInfo.Password = Convert.ToBase64String(TeaHelper.Encrypt(Encoding.UTF8.GetBytes(textPassword.Text), Const.TeaKey));
            File.WriteAllText(Const.CnblogSettingPath, JsonConvert.SerializeObject(connInfo));

            MessageBox.Show("配置账号成功");
        }
    }
}