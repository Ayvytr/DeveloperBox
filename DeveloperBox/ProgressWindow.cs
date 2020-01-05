using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeveloperBox
{
    public partial class ProgressWindow : Form
    {
        private Task<string> task = null;

        public ProgressWindow()
        {
            InitializeComponent();
        }

        private void ProgressWindow_Load(object sender, EventArgs e)
        {
            progressBar.PerformStep();
            progressBar.Value += 1;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if(progressBar.Value == 100)
            {
                Close();
                return;
            }
            progressBar.PerformStep();
            progressBar.Value += 1;
        }

        private void ProgressWIndow_Closed(object sender, FormClosedEventArgs e)
        {
            if(task != null && !task.IsCanceled)
            {
                task.Dispose();
            }
        }

        internal void setClosingTask(Task<string> task)
        {
            this.task = task;
        }
    }
}
