using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZXing;
using ZXing.QrCode;

namespace DeveloperBox
{
    partial class QrWindow : Form
    {
        private Bitmap bitmapEncode = null;

        public QrWindow()
        {
            InitializeComponent();
        }

        private void btnEncode_Click(object sender, EventArgs e)
        {
            String text = et.Text;
            if (text.Length == 0)
            {
                toolStripStatusLabel.Text = "NULL";
                bitmapEncode = null;
                return;
            }

            BarcodeWriter writer = new BarcodeWriter();
            writer.Format = BarcodeFormat.QR_CODE;
            QrCodeEncodingOptions options = new QrCodeEncodingOptions();
            options.DisableECI = true;
            //设置内容编码
            options.CharacterSet = "UTF-8";
            //将传来的值赋给二维码的宽度和高度
            options.Width = Convert.ToInt32(1024);
            options.Height = Convert.ToInt32(1024);
            //设置二维码的边距,单位不是固定像素
            options.Margin = 1;
            writer.Options = options;

            bitmapEncode = writer.Write(text);
            Bitmap target = Command.resizeImage(bitmapEncode, ivEncode.Width, ivEncode.Height);
            if (target != null)
            {
                ivEncode.Image = target;
            }
            else
            {
                bitmapEncode = null;
                MessageBox.Show(Properties.Resources.qrcode_encode_failed,
                    Properties.Resources.message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSaveQrCode_Click(object sender, EventArgs e)
        {
            if(bitmapEncode != null)
            {
                DialogResult dialogResult = saveFileDialog.ShowDialog();
                if(dialogResult == DialogResult.OK)
                {
                    MessageBox.Show(saveFileDialog.Title, saveFileDialog.FilterIndex.ToString());
                    saveEncodeBitmap(saveFileDialog.FileName, saveFileDialog.FilterIndex);
                }
            }
        }

        private void saveEncodeBitmap(string fileName, int filterIndex)
        {
            switch(filterIndex)
            {
                case 1:
                    bitmapEncode.Save(fileName, ImageFormat.Png);
                    break;
                case 2:
                    bitmapEncode.Save(fileName, ImageFormat.Jpeg);
                    break;
                case 3:
                    bitmapEncode.Save(fileName, ImageFormat.Bmp);
                    break;
                case 4:
                    bitmapEncode.Save(fileName, ImageFormat.Gif);
                    break;
                case 5:
                    bitmapEncode.Save(fileName, ImageFormat.Tiff);
                    break;
            }
        }

        private void btnDecode_Click(object sender, EventArgs e)
        {
            var dialogResult = openFileDialog.ShowDialog();
            if(dialogResult == DialogResult.OK){
                var image = Image.FromFile(openFileDialog.FileName);
                var bitmap = Command.resizeImage(image, ivEncode.Width, ivEncode.Height);
                if(bitmap != null)
                {
                    iv.Image = bitmap;
                }

                var reader = new BarcodeReader();
                var result = reader.Decode(new Bitmap(image));
                if(result != null && result.Text != null)
                {
                    etDecode.Text = result.Text;
                } else
                {
                    toolStripStatusLabel.Text = Properties.Resources.qrcode_decode_failed;
                }
            }
        }

        private void btnCopyDecode_Click(object sender, EventArgs e)
        {
            if(etDecode.Text.Length > 0)
            {
                Clipboard.SetText(etDecode.Text);
                toolStripStatusLabel.Text = Properties.Resources.copied_to_clipboard;
            }
        }

        private void et_TextChanged(object sender, EventArgs e)
        {

        }

        private void etDecode_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
