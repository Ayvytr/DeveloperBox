using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeveloperBox
{
    public partial class AboutWindow : Form
    {
        public AboutWindow()
        {
            InitializeComponent();
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

        private void linkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            openUrl(Command.ISSUES_URL);
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AboutWindow_Load(object sender, EventArgs e)
        {
            tvVersion.Text = Assembly.GetExecutingAssembly().GetName().Version.ToString();
        }
    }
}
