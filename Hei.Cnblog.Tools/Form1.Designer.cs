namespace Hei.Cnblog.Tools
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSelectFold = new System.Windows.Forms.Button();
            this.comboxPath = new System.Windows.Forms.ComboBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.treeViewFolder = new System.Windows.Forms.TreeView();
            this.IconList = new System.Windows.Forms.ImageList(this.components);
            this.textConsole = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.配置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sourceCode = new System.Windows.Forms.ToolStripMenuItem();
            this.about = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuItemNewDraft = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnSelectFold);
            this.panel1.Controls.Add(this.comboxPath);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1168, 42);
            this.panel1.TabIndex = 0;
            // 
            // btnSelectFold
            // 
            this.btnSelectFold.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSelectFold.Location = new System.Drawing.Point(1062, 7);
            this.btnSelectFold.Name = "btnSelectFold";
            this.btnSelectFold.Size = new System.Drawing.Size(103, 29);
            this.btnSelectFold.TabIndex = 1;
            this.btnSelectFold.Text = "打开目录...";
            this.btnSelectFold.UseVisualStyleBackColor = true;
            this.btnSelectFold.Click += new System.EventHandler(this.btnSelectFold_Click);
            // 
            // comboxPath
            // 
            this.comboxPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboxPath.FormattingEnabled = true;
            this.comboxPath.Location = new System.Drawing.Point(4, 7);
            this.comboxPath.Name = "comboxPath";
            this.comboxPath.Size = new System.Drawing.Size(1055, 28);
            this.comboxPath.TabIndex = 0;
            this.comboxPath.SelectedIndexChanged += new System.EventHandler(this.comboxPath_SelectedIndexChanged);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Cursor = System.Windows.Forms.Cursors.VSplit;
            this.splitContainer1.Location = new System.Drawing.Point(4, 69);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.treeViewFolder);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.AllowDrop = true;
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.White;
            this.splitContainer1.Panel2.Controls.Add(this.textConsole);
            this.splitContainer1.Panel2.Controls.Add(this.panel2);
            this.splitContainer1.Size = new System.Drawing.Size(1161, 654);
            this.splitContainer1.SplitterDistance = 400;
            this.splitContainer1.TabIndex = 1;
            // 
            // treeViewFolder
            // 
            this.treeViewFolder.AllowDrop = true;
            this.treeViewFolder.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.treeViewFolder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeViewFolder.ImageIndex = 0;
            this.treeViewFolder.ImageList = this.IconList;
            this.treeViewFolder.Location = new System.Drawing.Point(0, 0);
            this.treeViewFolder.Name = "treeViewFolder";
            this.treeViewFolder.SelectedImageIndex = 0;
            this.treeViewFolder.Size = new System.Drawing.Size(400, 654);
            this.treeViewFolder.TabIndex = 0;
            this.treeViewFolder.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.treeViewFolder_ItemDrag);
            this.treeViewFolder.MouseDown += new System.Windows.Forms.MouseEventHandler(this.treeViewFolder_MouseDown);
            // 
            // IconList
            // 
            this.IconList.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.IconList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("IconList.ImageStream")));
            this.IconList.TransparentColor = System.Drawing.Color.Transparent;
            this.IconList.Images.SetKeyName(0, "folder.png");
            this.IconList.Images.SetKeyName(1, "cfolder.png");
            this.IconList.Images.SetKeyName(2, "markdown.png");
            this.IconList.Images.SetKeyName(3, "file.png");
            // 
            // textConsole
            // 
            this.textConsole.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textConsole.BackColor = System.Drawing.Color.White;
            this.textConsole.ForeColor = System.Drawing.Color.White;
            this.textConsole.Location = new System.Drawing.Point(10, 156);
            this.textConsole.Multiline = true;
            this.textConsole.Name = "textConsole";
            this.textConsole.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textConsole.Size = new System.Drawing.Size(738, 490);
            this.textConsole.TabIndex = 1;
            this.textConsole.WordWrap = false;
            // 
            // panel2
            // 
            this.panel2.AllowDrop = true;
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(10, 11);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(738, 139);
            this.panel2.TabIndex = 0;
            this.panel2.DragDrop += new System.Windows.Forms.DragEventHandler(this.panel2_DragDrop);
            this.panel2.DragEnter += new System.Windows.Forms.DragEventHandler(this.panel2_DragEnter);
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("幼圆", 14.04878F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(128, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(526, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "从右侧拓展或直接拖曳Markdown/图片文件到此处";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(313, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(104, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.配置ToolStripMenuItem,
            this.sourceCode,
            this.about});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1168, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 配置ToolStripMenuItem
            // 
            this.配置ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem});
            this.配置ToolStripMenuItem.Name = "配置ToolStripMenuItem";
            this.配置ToolStripMenuItem.Size = new System.Drawing.Size(71, 24);
            this.配置ToolStripMenuItem.Text = "设置(c)";
            // 
            // ToolStripMenuItem
            // 
            this.ToolStripMenuItem.Name = "ToolStripMenuItem";
            this.ToolStripMenuItem.Size = new System.Drawing.Size(155, 28);
            this.ToolStripMenuItem.Text = "配置账号";
            this.ToolStripMenuItem.Click += new System.EventHandler(this.ToolStripMenuItem_Click);
            // 
            // sourceCode
            // 
            this.sourceCode.Name = "sourceCode";
            this.sourceCode.Size = new System.Drawing.Size(53, 24);
            this.sourceCode.Text = "源码";
            this.sourceCode.Click += new System.EventHandler(this.sourceCode_Click);
            // 
            // about
            // 
            this.about.Name = "about";
            this.about.Size = new System.Drawing.Size(53, 24);
            this.about.Text = "关于";
            this.about.Click += new System.EventHandler(this.about_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemNewDraft});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(215, 56);
            // 
            // menuItemNewDraft
            // 
            this.menuItemNewDraft.Name = "menuItemNewDraft";
            this.menuItemNewDraft.Size = new System.Drawing.Size(214, 24);
            this.menuItemNewDraft.Text = "快速编辑发布此文";
            this.menuItemNewDraft.Click += new System.EventHandler(this.menuItemNewDraft_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1168, 727);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CnblogTool(嘿~)";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SplitContainer splitContainer1;
        private Panel panel1;
        private Button btnSelectFold;
        private ComboBox comboxPath;
        private TreeView treeViewFolder;
        private ImageList IconList;
        private Panel panel2;
        private TextBox textConsole;
        private Label label1;
        private PictureBox pictureBox1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem 配置ToolStripMenuItem;
        private ToolStripMenuItem ToolStripMenuItem;
        private ToolStripMenuItem about;
        private ToolStripMenuItem sourceCode;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem menuItemNewDraft;
    }
}