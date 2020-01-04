using System;

namespace DeveloperBox
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出QToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.工具ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.二维码生成解析QToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助HToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gitHubToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.issuesIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.et = new System.Windows.Forms.RichTextBox();
            this.etRight = new System.Windows.Forms.RichTextBox();
            this.groupBoxMiddle = new System.Windows.Forms.GroupBox();
            this.btnUrlDecode = new System.Windows.Forms.Button();
            this.btnUrlEncode = new System.Windows.Forms.Button();
            this.btnJsonFormat = new System.Windows.Forms.Button();
            this.btnToEnglish = new System.Windows.Forms.Button();
            this.btnToChinese = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.groupBoxMiddle.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.文件ToolStripMenuItem,
            this.工具ToolStripMenuItem,
            this.帮助HToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(800, 25);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // 文件ToolStripMenuItem
            // 
            this.文件ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.退出QToolStripMenuItem});
            this.文件ToolStripMenuItem.Name = "文件ToolStripMenuItem";
            this.文件ToolStripMenuItem.Size = new System.Drawing.Size(58, 21);
            this.文件ToolStripMenuItem.Text = "文件(&F)";
            this.文件ToolStripMenuItem.Click += new System.EventHandler(this.文件ToolStripMenuItem_Click);
            // 
            // 退出QToolStripMenuItem
            // 
            this.退出QToolStripMenuItem.Name = "退出QToolStripMenuItem";
            this.退出QToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.退出QToolStripMenuItem.Text = "退出(&X)";
            this.退出QToolStripMenuItem.Click += new System.EventHandler(this.退出QToolStripMenuItem_Click);
            // 
            // 工具ToolStripMenuItem
            // 
            this.工具ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.二维码生成解析QToolStripMenuItem});
            this.工具ToolStripMenuItem.Name = "工具ToolStripMenuItem";
            this.工具ToolStripMenuItem.Size = new System.Drawing.Size(59, 21);
            this.工具ToolStripMenuItem.Text = "工具(&T)";
            this.工具ToolStripMenuItem.Click += new System.EventHandler(this.工具ToolStripMenuItem_Click);
            // 
            // 二维码生成解析QToolStripMenuItem
            // 
            this.二维码生成解析QToolStripMenuItem.Name = "二维码生成解析QToolStripMenuItem";
            this.二维码生成解析QToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.二维码生成解析QToolStripMenuItem.Text = "二维码生成/解析(&Q)";
            this.二维码生成解析QToolStripMenuItem.Click += new System.EventHandler(this.二维码生成解析QToolStripMenuItem_Click);
            // 
            // 帮助HToolStripMenuItem
            // 
            this.帮助HToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gitHubToolStripMenuItem,
            this.issuesIToolStripMenuItem,
            this.aboutAToolStripMenuItem});
            this.帮助HToolStripMenuItem.Name = "帮助HToolStripMenuItem";
            this.帮助HToolStripMenuItem.Size = new System.Drawing.Size(61, 21);
            this.帮助HToolStripMenuItem.Text = "帮助(&H)";
            // 
            // gitHubToolStripMenuItem
            // 
            this.gitHubToolStripMenuItem.Name = "gitHubToolStripMenuItem";
            this.gitHubToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.gitHubToolStripMenuItem.Text = "GitHub(&G)";
            this.gitHubToolStripMenuItem.Click += new System.EventHandler(this.gitHubToolStripMenuItem_Click);
            // 
            // issuesIToolStripMenuItem
            // 
            this.issuesIToolStripMenuItem.Name = "issuesIToolStripMenuItem";
            this.issuesIToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.issuesIToolStripMenuItem.Text = "Issues(&I)";
            this.issuesIToolStripMenuItem.Click += new System.EventHandler(this.issuesIToolStripMenuItem_Click);
            // 
            // aboutAToolStripMenuItem
            // 
            this.aboutAToolStripMenuItem.Name = "aboutAToolStripMenuItem";
            this.aboutAToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.aboutAToolStripMenuItem.Text = "About(&A)";
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel3});
            this.statusStrip.Location = new System.Drawing.Point(0, 579);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(800, 22);
            this.statusStrip.TabIndex = 1;
            this.statusStrip.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(785, 17);
            this.toolStripStatusLabel2.Spring = true;
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(0, 17);
            // 
            // et
            // 
            this.et.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.et.Location = new System.Drawing.Point(0, 28);
            this.et.Name = "et";
            this.et.Size = new System.Drawing.Size(293, 548);
            this.et.TabIndex = 2;
            this.et.Text = "";
            // 
            // etRight
            // 
            this.etRight.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.etRight.Location = new System.Drawing.Point(477, 28);
            this.etRight.Name = "etRight";
            this.etRight.Size = new System.Drawing.Size(323, 548);
            this.etRight.TabIndex = 3;
            this.etRight.Text = "";
            // 
            // groupBoxMiddle
            // 
            this.groupBoxMiddle.Controls.Add(this.btnUrlDecode);
            this.groupBoxMiddle.Controls.Add(this.btnUrlEncode);
            this.groupBoxMiddle.Controls.Add(this.btnJsonFormat);
            this.groupBoxMiddle.Controls.Add(this.btnToEnglish);
            this.groupBoxMiddle.Controls.Add(this.btnToChinese);
            this.groupBoxMiddle.Location = new System.Drawing.Point(299, 28);
            this.groupBoxMiddle.Name = "groupBoxMiddle";
            this.groupBoxMiddle.Size = new System.Drawing.Size(180, 548);
            this.groupBoxMiddle.TabIndex = 4;
            this.groupBoxMiddle.TabStop = false;
            this.groupBoxMiddle.Text = "点击转换";
            // 
            // btnUrlDecode
            // 
            this.btnUrlDecode.Location = new System.Drawing.Point(6, 244);
            this.btnUrlDecode.Name = "btnUrlDecode";
            this.btnUrlDecode.Size = new System.Drawing.Size(166, 50);
            this.btnUrlDecode.TabIndex = 4;
            this.btnUrlDecode.Text = "URL解码";
            this.btnUrlDecode.UseVisualStyleBackColor = true;
            this.btnUrlDecode.Click += new System.EventHandler(this.btnUrlDecode_Click);
            // 
            // btnUrlEncode
            // 
            this.btnUrlEncode.Location = new System.Drawing.Point(6, 188);
            this.btnUrlEncode.Name = "btnUrlEncode";
            this.btnUrlEncode.Size = new System.Drawing.Size(166, 50);
            this.btnUrlEncode.TabIndex = 3;
            this.btnUrlEncode.Text = "URL编码";
            this.btnUrlEncode.UseVisualStyleBackColor = true;
            this.btnUrlEncode.Click += new System.EventHandler(this.btnUrlEncode_Click);
            // 
            // btnJsonFormat
            // 
            this.btnJsonFormat.Location = new System.Drawing.Point(6, 132);
            this.btnJsonFormat.Name = "btnJsonFormat";
            this.btnJsonFormat.Size = new System.Drawing.Size(166, 50);
            this.btnJsonFormat.TabIndex = 2;
            this.btnJsonFormat.Text = "Json格式化";
            this.btnJsonFormat.UseVisualStyleBackColor = true;
            this.btnJsonFormat.Click += new System.EventHandler(this.btnJsonFormat_Click);
            // 
            // btnToEnglish
            // 
            this.btnToEnglish.Location = new System.Drawing.Point(6, 76);
            this.btnToEnglish.Name = "btnToEnglish";
            this.btnToEnglish.Size = new System.Drawing.Size(166, 50);
            this.btnToEnglish.TabIndex = 1;
            this.btnToEnglish.Text = "转换为英文";
            this.btnToEnglish.UseVisualStyleBackColor = true;
            // 
            // btnToChinese
            // 
            this.btnToChinese.Location = new System.Drawing.Point(6, 20);
            this.btnToChinese.Name = "btnToChinese";
            this.btnToChinese.Size = new System.Drawing.Size(166, 50);
            this.btnToChinese.TabIndex = 0;
            this.btnToChinese.Text = "转换为中文";
            this.btnToChinese.UseVisualStyleBackColor = true;
            this.btnToChinese.Click += new System.EventHandler(this.BtnToChinese_Click);
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 601);
            this.Controls.Add(this.groupBoxMiddle);
            this.Controls.Add(this.etRight);
            this.Controls.Add(this.et);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.MinimumSize = new System.Drawing.Size(800, 640);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.SizeChanged += new System.EventHandler(this.Window_Resize);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.groupBoxMiddle.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripMenuItem 文件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 工具ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 帮助HToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出QToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 二维码生成解析QToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gitHubToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem issuesIToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutAToolStripMenuItem;
        private System.Windows.Forms.RichTextBox et;
        private System.Windows.Forms.RichTextBox etRight;
        private System.Windows.Forms.GroupBox groupBoxMiddle;
        private System.Windows.Forms.Button btnUrlDecode;
        private System.Windows.Forms.Button btnUrlEncode;
        private System.Windows.Forms.Button btnJsonFormat;
        private System.Windows.Forms.Button btnToEnglish;
        private System.Windows.Forms.Button btnToChinese;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.Timer timer;
    }
}

