using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MacEditor
{
    public partial class TabIndentChange : Form
    {
        public TabIndentChange()
        {
            InitializeComponent();
            timer.Interval = 10;
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private Timer timer = new Timer();

        private void Timer_Tick(object sender, EventArgs e)
        {
            trackBar1_Scroll(sender, e);
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            tiDisplay.Text = trackBar1.Value.ToString();
            appinfo.Default.teTabIndent = trackBar1.Value;
            appinfo.Default.Save();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            appinfo.Default.Save();
            timer.Dispose();
            Close();
        }

        private void TabIndentChange_Load(object sender, EventArgs e)
        {
            tiDisplay.Text = appinfo.Default.teTabIndent.ToString();
            trackBar1.Value = appinfo.Default.teTabIndent;
            appinfo.Default.Save();
        }
    }
}
