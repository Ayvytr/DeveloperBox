namespace DeveloperBox
{
    partial class QrWindow
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
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
            this.btnEncode = new System.Windows.Forms.Button();
            this.ivEncode = new System.Windows.Forms.PictureBox();
            this.et = new System.Windows.Forms.TextBox();
            this.btnSaveQrCode = new System.Windows.Forms.Button();
            this.btnCopyDecode = new System.Windows.Forms.Button();
            this.etDecode = new System.Windows.Forms.TextBox();
            this.iv = new System.Windows.Forms.PictureBox();
            this.btnDecode = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.ivEncode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iv)).BeginInit();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnEncode
            // 
            this.btnEncode.Location = new System.Drawing.Point(318, 110);
            this.btnEncode.Name = "btnEncode";
            this.btnEncode.Size = new System.Drawing.Size(120, 50);
            this.btnEncode.TabIndex = 0;
            this.btnEncode.Text = "生成";
            this.btnEncode.UseVisualStyleBackColor = true;
            this.btnEncode.Click += new System.EventHandler(this.btnEncode_Click);
            // 
            // ivEncode
            // 
            this.ivEncode.Location = new System.Drawing.Point(444, 11);
            this.ivEncode.Name = "ivEncode";
            this.ivEncode.Size = new System.Drawing.Size(240, 240);
            this.ivEncode.TabIndex = 1;
            this.ivEncode.TabStop = false;
            // 
            // et
            // 
            this.et.Location = new System.Drawing.Point(12, 110);
            this.et.MinimumSize = new System.Drawing.Size(200, 50);
            this.et.Name = "et";
            this.et.Size = new System.Drawing.Size(300, 21);
            this.et.TabIndex = 2;
            // 
            // btnSaveQrCode
            // 
            this.btnSaveQrCode.Location = new System.Drawing.Point(690, 110);
            this.btnSaveQrCode.Name = "btnSaveQrCode";
            this.btnSaveQrCode.Size = new System.Drawing.Size(120, 50);
            this.btnSaveQrCode.TabIndex = 3;
            this.btnSaveQrCode.Text = "保存二维码";
            this.btnSaveQrCode.UseVisualStyleBackColor = true;
            this.btnSaveQrCode.Click += new System.EventHandler(this.btnSaveQrCode_Click);
            // 
            // btnCopyDecode
            // 
            this.btnCopyDecode.Location = new System.Drawing.Point(690, 360);
            this.btnCopyDecode.Name = "btnCopyDecode";
            this.btnCopyDecode.Size = new System.Drawing.Size(120, 50);
            this.btnCopyDecode.TabIndex = 7;
            this.btnCopyDecode.Text = "复制解析内容";
            this.btnCopyDecode.UseVisualStyleBackColor = true;
            this.btnCopyDecode.Click += new System.EventHandler(this.btnCopyDecode_Click);
            // 
            // etDecode
            // 
            this.etDecode.Location = new System.Drawing.Point(384, 360);
            this.etDecode.MinimumSize = new System.Drawing.Size(200, 50);
            this.etDecode.Name = "etDecode";
            this.etDecode.Size = new System.Drawing.Size(300, 21);
            this.etDecode.TabIndex = 6;
            // 
            // iv
            // 
            this.iv.Location = new System.Drawing.Point(12, 264);
            this.iv.Name = "iv";
            this.iv.Size = new System.Drawing.Size(240, 240);
            this.iv.TabIndex = 5;
            this.iv.TabStop = false;
            // 
            // btnDecode
            // 
            this.btnDecode.Location = new System.Drawing.Point(258, 360);
            this.btnDecode.Name = "btnDecode";
            this.btnDecode.Size = new System.Drawing.Size(120, 50);
            this.btnDecode.TabIndex = 4;
            this.btnDecode.Text = "选择图片并解析";
            this.btnDecode.UseVisualStyleBackColor = true;
            this.btnDecode.Click += new System.EventHandler(this.btnDecode_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.Filter = "Png|*.png|Jpeg|*.Jpeg|Bmp|*.bmp|Gif|*.gif|Tiff|*.tiff";
            this.saveFileDialog.Title = "保存二维码";
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(9, 514);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(806, 22);
            this.statusStrip.TabIndex = 8;
            this.statusStrip.Text = "statusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // QrWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 544);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.btnCopyDecode);
            this.Controls.Add(this.etDecode);
            this.Controls.Add(this.iv);
            this.Controls.Add(this.btnDecode);
            this.Controls.Add(this.btnSaveQrCode);
            this.Controls.Add(this.et);
            this.Controls.Add(this.ivEncode);
            this.Controls.Add(this.btnEncode);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "QrWindow";
            this.Padding = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "生成/解析二维码";
            ((System.ComponentModel.ISupportInitialize)(this.ivEncode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iv)).EndInit();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEncode;
        private System.Windows.Forms.PictureBox ivEncode;
        private System.Windows.Forms.TextBox et;
        private System.Windows.Forms.Button btnSaveQrCode;
        private System.Windows.Forms.Button btnCopyDecode;
        private System.Windows.Forms.TextBox etDecode;
        private System.Windows.Forms.PictureBox iv;
        private System.Windows.Forms.Button btnDecode;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
    }
}
