namespace Hei.Cnblog.Tools
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.textUserName = new System.Windows.Forms.TextBox();
            this.textPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnComfirm = new System.Windows.Forms.Button();
            this.textBlogid = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.blogid = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "账号：";
            // 
            // textUserName
            // 
            this.textUserName.Location = new System.Drawing.Point(73, 89);
            this.textUserName.Name = "textUserName";
            this.textUserName.Size = new System.Drawing.Size(356, 27);
            this.textUserName.TabIndex = 1;
            // 
            // textPassword
            // 
            this.textPassword.Location = new System.Drawing.Point(73, 123);
            this.textPassword.Name = "textPassword";
            this.textPassword.Size = new System.Drawing.Size(356, 27);
            this.textPassword.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "密码：";
            // 
            // btnComfirm
            // 
            this.btnComfirm.Location = new System.Drawing.Point(14, 165);
            this.btnComfirm.Name = "btnComfirm";
            this.btnComfirm.Size = new System.Drawing.Size(415, 29);
            this.btnComfirm.TabIndex = 4;
            this.btnComfirm.Text = "确认";
            this.btnComfirm.UseVisualStyleBackColor = true;
            this.btnComfirm.Click += new System.EventHandler(this.btnComfirm_Click);
            // 
            // textBlogid
            // 
            this.textBlogid.Location = new System.Drawing.Point(73, 54);
            this.textBlogid.Name = "textBlogid";
            this.textBlogid.Size = new System.Drawing.Size(356, 27);
            this.textBlogid.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "博客ID:";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(12, 9);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(266, 20);
            this.linkLabel1.TabIndex = 7;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "https://www.cnblogs.com/xiaxiaolu";
            // 
            // blogid
            // 
            this.blogid.AutoSize = true;
            this.blogid.Location = new System.Drawing.Point(12, 31);
            this.blogid.Name = "blogid";
            this.blogid.Size = new System.Drawing.Size(417, 20);
            this.blogid.TabIndex = 8;
            this.blogid.Text = "博客ID每个账号唯一如上是我的博客园地址，ID为：xiaxiaolu";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 203);
            this.Controls.Add(this.blogid);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.textBlogid);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnComfirm);
            this.Controls.Add(this.textPassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textUserName);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "配置账号";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox textUserName;
        private TextBox textPassword;
        private Label label2;
        private Button btnComfirm;
        private TextBox textBlogid;
        private Label label3;
        private LinkLabel linkLabel1;
        private Label blogid;
    }
}