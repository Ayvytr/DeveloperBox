using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace DeveloperBox
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void 文件ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 工具ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 退出QToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void gitHubToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openUrl(Command.GITHUB_URL);
        }

        private void Window_Resize(object sender, EventArgs e)
        {
            resizeWidgets();
        }

        private void resizeWidgets()
        {
            int width = (Width - groupBoxMiddle.Width) / 2 - 10;
            this.et.Width = width;
            this.etRight.Width = width;
            this.groupBoxMiddle.Left = width;
            this.etRight.Left = width + groupBoxMiddle.Width;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            resizeWidgets();
            toolStripStatusLabel3.Text = DateTime.Now.ToLocalTime().ToString();
        }

        private void btnUrlEncode_Click(object sender, EventArgs e)
        {
            execCommand(Command.Type.URL_ENCODE);
        }

        private void BtnToChinese_Click(object sender, EventArgs e)
        {
            execCommand(Command.Type.TRANSLATE_TO_CN);
        }

        private void execCommand(Command.Type type)
        {
            if(et.Text.Length == 0)
            {
                toolStripStatusLabel1.Text = "NUll!";
                return;
            }
            
            switch(type)
            {
                case Command.Type.TRANSLATE_TO_CN:
                    translateToChinese();
                    break;
                case Command.Type.TRANSLATE_TO_EN:
                    translateToEnglish();
                    break;
                case Command.Type.JSON_FORMAT:
                    jsonFormat();
                    break;
                case Command.Type.URL_ENCODE:
                    urlEncode();
                    break;
                case Command.Type.URL_DECODE:
                    urlDecode();
                    break;
            }
        }

        private void urlDecode()
        {
            string result = HttpUtility.UrlDecode(et.Text, Encoding.UTF8);
            etRight.Text = result;
        }

        private void urlEncode()
        {
            string result = HttpUtility.UrlEncode(et.Text);
            etRight.Text = result;
        }

        private void jsonFormat()
        {
            String result = Command.jsonFormat(et.Text);
            if (result == null)
            {
                toolStripStatusLabel1.Text = Properties.Resources.json_format_error;
            }
            else
            {
                etRight.Text = result;
            }
        }

        private async void translateToEnglish()
        {
            try
            {
                var body = await Command.httpClient.GetStringAsync(Command.URL_TO_EN + et.Text);
                etRight.Text = body;
            }
            catch (TaskCanceledException canceledException)
            {
                showTaskCanceledException(canceledException);
            }
            catch (Exception exception)
            {
                showExceptionIssueDialog(exception);
            }
        }

        private void showExceptionIssueDialog(Exception exception)
        {
            string msg = Properties.Resources.app_occur_error + "\n\n" + exception.ToString();
            DialogResult dialogResult = MessageBox.Show(msg, Properties.Resources.message, 
                MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            if (dialogResult == DialogResult.OK)
            {
                openUrl(Command.ISSUES_URL);
            }
        }

        private void openUrl(string url)
        {
            try
            {
                System.Diagnostics.Process.Start(url);
            }
            catch (Win32Exception noBrowser)
            {
                if (noBrowser.ErrorCode == -2147467259)
                    MessageBox.Show(noBrowser.Message);
            }
            catch (System.Exception other)
            {
                MessageBox.Show(other.Message);
            }
        }

        private void showTaskCanceledException(TaskCanceledException canceledException)
        {
            string msg = canceledException.GetType().ToString() + "\n可能是网络中断了";
            MessageBox.Show(msg, Properties.Resources.message, MessageBoxButtons.OK);
        }

        private async void translateToChinese()
        {
            try
            {
                var body = await Command.httpClient.GetStringAsync(Command.URL_TO_CN + et.Text);
                etRight.Text = body;
            }
            catch (TaskCanceledException canceledException)
            {
                string msg = canceledException.GetType().ToString() + "\n可能是网络中断了";
                MessageBox.Show(msg, Properties.Resources.message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception exception)
            {
                showExceptionIssueDialog(exception);
            }
        }

        private void btnJsonFormat_Click(object sender, EventArgs e)
        {
            execCommand(Command.Type.JSON_FORMAT);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel3.Text = DateTime.Now.ToLocalTime().ToString();
        }

        private void btnUrlDecode_Click(object sender, EventArgs e)
        {
            execCommand(Command.Type.URL_DECODE);
        }

        private void issuesIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openUrl(Command.ISSUES_URL);
        }

        private void 二维码生成解析QToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new QrWindow().ShowDialog();
        }

        private void aboutAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new AboutWindow().ShowDialog();
        }
    }
}
