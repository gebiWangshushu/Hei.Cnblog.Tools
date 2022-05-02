using CnBlogPublishTool;
using CnBlogPublishTool.Processor;
using CnBlogPublishTool.Util;
using MetaWeblogClient;
using Newtonsoft.Json;
using System.Diagnostics;
using System.Drawing.Drawing2D;
using System.IO;

namespace Hei.Cnblog.Tools
{
    public partial class Form1 : Form
    {
        private static readonly Dictionary<string, string> ReplaceDic = new Dictionary<string, string>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.textConsole.BackColor = Color.FromArgb(41, 49, 52);
            if (File.Exists(Const.Appsettings))
            {
                var config = JsonConvert.DeserializeObject<Appsettings>(File.ReadAllText(Const.Appsettings));
                if (config.RecentDir?.Dirs?.Count > 0 == true)
                {
                    initTreeNode(config.RecentDir.Dirs.Last());
                    config.RecentDir.Dirs.Reverse();
                    this.comboxPath.Items.AddRange(config.RecentDir.Dirs.ToArray());
                }
            }

            //ImageUploader.Init(Const.CnblogSettingPath, Const.TeaKey);
            //var postId = ImageUploader.BlogClient.NewPost("测试发布", "测试发布", new List<string> { "[Markdown]" }, false, DateTime.Now);
            //Process.Start(new ProcessStartInfo($"https://www.cnblogs.com/ChildishChange/p/{postId}.html") { UseShellExecute = true });

            //var editResult = ImageUploader.BlogClient.EditPost("16216527", "测试发布", "测试描述222222222222222222222222222222222222222222222<br>sdsdf", new List<string> { "[Markdown]" }, false);
        }

        private void setRecentDirs(string path)
        {
            if (File.Exists(Const.Appsettings))
            {
                var config = JsonConvert.DeserializeObject<Appsettings>(File.ReadAllText(Const.Appsettings));
                if (config.RecentDir?.Dirs?.Count >= config.RecentDir.MaxRecond)
                {
                    config.RecentDir.Dirs[config.RecentDir.MaxRecond - 1] = path;
                }
                else
                {
                    if (config?.RecentDir?.Dirs?.Contains(path) == true)
                    {
                        config.RecentDir?.Dirs.Remove(path);
                    }
                    config.RecentDir?.Dirs.Add(path);
                }
                File.WriteAllText(Const.Appsettings, JsonConvert.SerializeObject(config));
            }
        }

        private void btnSelectFold_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            folderBrowserDialog.Description = "请选择博客md文件目录";
            folderBrowserDialog.SelectedPath = Application.StartupPath;
            folderBrowserDialog.ShowNewFolderButton = true;
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                initTreeNode(folderBrowserDialog.SelectedPath);
            }
        }

        private void initTreeNode(string path)
        {
            comboxPath.Text = path;
            treeViewFolder.Nodes.Clear();
            TreeNode rootNode = new TreeNode();
            rootNode.ExpandAll();

            initTreeNode(comboxPath.Text, rootNode);
            treeViewFolder.Nodes.Add(rootNode);
            setRecentDirs(path);
        }

        private void initTreeNode(string folderPath, TreeNode parentNode)
        {
            parentNode.Text = Path.GetFileNameWithoutExtension(folderPath);
            DirectoryInfo tempDir = null;
            TreeNode subNode = null;

            //读取文件夹下的目录
            string[] dics = Directory.GetDirectories(folderPath);
            foreach (string dic in dics)
            {
                tempDir = new DirectoryInfo(dic);
                subNode = new TreeNode(tempDir.Name); //实例化
                subNode.Name = new DirectoryInfo(dic).Name; //.FullName//完整目录
                subNode.Tag = subNode.Name;
                subNode.ImageIndex = Icons.Floder;       //获取节点显示图片
                subNode.SelectedImageIndex = Icons.Selected; //选择节点显示图片
                //subNode.Nodes.Add("");   //加载空节点 实现+号

                parentNode.Nodes.Add(subNode);

                //递归读取所有子目录,这里我就不递归读了
                //initTreeNode(tempDir.FullName, subNode);
            }

            //读取文件夹下的文件
            TreeNode fileNode = null;
            string[] tempFiles = Directory.GetFiles(folderPath);

            var orderFiles = tempFiles.OrderByDescending(ss => new FileInfo(ss).LastWriteTime).ToArray();
            foreach (string fileFullName in orderFiles)
            {
                fileNode = new TreeNode(fileFullName);
                fileNode.Name = fileFullName;
                fileNode.Text = Path.GetFileName(fileFullName);
                fileNode.SelectedImageIndex = Icons.Selected; //选择节点显示图片

                if (fileFullName.Contains(".md", StringComparison.OrdinalIgnoreCase))
                {
                    fileNode.ImageIndex = Icons.Markdown;
                }
                else
                {
                    fileNode.ImageIndex = Icons.File;
                }
                parentNode.Nodes.Add(fileNode);
            }
        }

        private void comboxPath_SelectedIndexChanged(object sender, EventArgs e)
        {
            initTreeNode(this.comboxPath.Text);
        }

        private void treeViewFolder_ItemDrag(object sender, ItemDragEventArgs e)
        {
            IDataObject data = new DataObject();
            data.SetData("dragnode", e.Item);
            this.DoDragDrop(data, DragDropEffects.Copy);
        }

        private void panel2_DragEnter(object sender, DragEventArgs e)
        {
            var treeNode = e?.Data?.GetDataPresent("dragnode") != null;

            if (treeNode == false)
            {
                if (e?.Data?.GetDataPresent(DataFormats.FileDrop) != null)
                {
                    e.Effect = DragDropEffects.Copy;
                }
                else
                {
                    e.Effect = DragDropEffects.None;
                }
            }
            else
            {
                if (e?.Data?.GetDataPresent("dragnode") != null)
                {
                    e.Effect = DragDropEffects.Copy;
                }
                else
                {
                    e.Effect = DragDropEffects.None;
                }
            }
        }

        private void loadBlogAccount()
        {
            if (File.Exists(Const.CnblogSettingPath) == false)
            {
                new Form2().ShowDialog();
                return;
            }
            else
            {
                ImageUploader.Init(Const.CnblogSettingPath, Const.TeaKey);
            }
        }

        private void panel2_DragDrop(object sender, DragEventArgs e)
        {
            try
            {
                loadBlogAccount();
                object nodeItem = e.Data.GetData("dragnode");

                if (nodeItem != null)
                {
                    TreeNode node = (TreeNode)nodeItem;
                    echo($"正在处理文件：{node.Name}");
                    processFile(node.Name);
                }
                else
                {
                    string dropFilePath = ((Array)e.Data?.GetData(DataFormats.FileDrop))?.GetValue(0)?.ToString();
                    var extension = Path.GetExtension(dropFilePath);
                    if (extension.Contains(".md", StringComparison.OrdinalIgnoreCase))
                    {
                        processFile(dropFilePath);
                    }
                    else if (Const.SupportImageType.Contains(extension, StringComparison.OrdinalIgnoreCase))
                    {
                        var imgUrl = ImageUploader.Upload(dropFilePath);
                        echo($"图片{dropFilePath} 上传成功 \r\n {imgUrl}\r\n![{Path.GetFileName(dropFilePath)}]({imgUrl})");
                    }
                    else
                    {
                        MessageBox.Show("暂只支持上传markdown文件和图片！");
                    }
                }
            }
            catch (Exception ex)
            {
                echo(ex.Message + ex.StackTrace);
            }
        }

        private void processFile(string filePath)
        {
            try
            {
                if (!File.Exists(filePath))
                {
                    echo("指定的文件不存在！");
                }
                else
                {
                    var uploadSuccess = 0;
                    var _fileDir = new FileInfo(filePath).DirectoryName;
                    var _fileContent = File.ReadAllText(filePath);
                    var imgProcessor = new ImageProcessor();
                    var imgList = imgProcessor.Process(_fileContent);
                    echo($"提取图片成功，共{imgList.Count}个");

                    //循环上传图片
                    foreach (var img in imgList)
                    {
                        if (img.StartsWith("http", StringComparison.OrdinalIgnoreCase))
                        {
                            echo($"{img} 跳过");
                            continue;
                        }

                        try
                        {
                            string imgPhyPath = Path.Combine(_fileDir, img);
                            if (File.Exists(imgPhyPath))
                            {
                                var imgUrl = ImageUploader.Upload(imgPhyPath);
                                echo($"{img} 上传成功+{++uploadSuccess}. {imgUrl}");
                                if (!ReplaceDic.ContainsKey(img))
                                {
                                    ReplaceDic.Add(img, imgUrl);
                                }
                            }
                            else
                            {
                                echo($"{img} 未发现文件");
                            }
                        }
                        catch (Exception e)
                        {
                            echo(e.Message + e.StackTrace);
                        }
                    }

                    //替换
                    foreach (var key in ReplaceDic.Keys)
                    {
                        _fileContent = _fileContent.Replace(key, ReplaceDic[key]);
                    }
                    File.WriteAllText(filePath, _fileContent, EncodingType.GetType(filePath));

                    echo($"共提取图片{imgList.Count}，上传成功{uploadSuccess}张，处理完成!");
                }
            }
            catch (Exception e)
            {
                echo(e.Message + e.StackTrace);
            }
        }

        /// <summary>
        /// 输出一行到控制台
        /// </summary>
        /// <param name="content"></param>
        private void echo(string content)
        {
            this.textConsole.Text += $"{content}\r\n";
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            Panel pan = (Panel)sender;
            float width = (float)4.0;
            Pen pen = new Pen(SystemColors.ControlDark, width);
            pen.DashStyle = DashStyle.Dot;
            e.Graphics.DrawLine(pen, 0, 0, 0, pan.Height - 0);
            e.Graphics.DrawLine(pen, 0, 0, pan.Width - 0, 0);
            e.Graphics.DrawLine(pen, pan.Width - 1, pan.Height - 1, 0, pan.Height - 1);
            e.Graphics.DrawLine(pen, pan.Width - 1, pan.Height - 1, pan.Width - 1, 0);
        }

        private void ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Form2().ShowDialog();
        }

        private void about_Click(object sender, EventArgs e)
        {
            new Form3().ShowDialog();
        }

        private void sourceCode_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo("https://github.com/gebiwangshushu/hei.cnblog.tools") { UseShellExecute = true });
        }

        private void treeViewFolder_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                Point ClickPoint = new Point(e.X, e.Y);
                TreeNode currentNode = treeViewFolder.GetNodeAt(ClickPoint);
                if (currentNode != null)
                {
                    treeViewFolder.SelectedNode = currentNode;
                    treeViewFolder.SelectedNode.ContextMenuStrip = contextMenuStrip1;
                }
            }
        }

        private void menuItemNewDraft_Click(object sender, EventArgs e)
        {
            if (treeViewFolder.SelectedNode != null)
            {
                loadBlogAccount();
                var fileFullName = treeViewFolder.SelectedNode.Name;
                if (fileFullName.Contains(".md", StringComparison.OrdinalIgnoreCase))
                {
                    try
                    {
                        processFile(fileFullName);
                        var title = Path.GetFileNameWithoutExtension(fileFullName);
                        var content = File.ReadAllText(treeViewFolder.SelectedNode.Name);
                        var postId = ImageUploader.BlogClient.NewPost(title, content, new List<string> { "[Markdown]" }, false, DateTime.Now);
                        var postUrl = $"https://www.cnblogs.com/{ImageUploader.BlogClient.BlogConnectionInfo.BlogID}/p/{postId}.html";
                        echo($"快速编辑文章成功：{postUrl}");
                        Process.Start(new ProcessStartInfo(postUrl) { UseShellExecute = true });
                    }
                    catch (Exception ex)
                    {
                        echo(ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("暂只支持上传markdown文件(.md)快速编辑发布");
                }
            }
        }
    }
}