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
    public partial class DefaultFileExtensionIndex : Form
    {
        public DefaultFileExtensionIndex()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            appinfo.Default.shDefFileExt = Convert.ToInt32(index1.Value);
            appinfo.Default.teDefFileExt = Convert.ToInt32(index2.Value);
            appinfo.Default.Save();
            Close();
        }

        private void DefaultFileExtensionIndex_Load(object sender, EventArgs e)
        {
            index1.Value = Convert.ToDecimal(appinfo.Default.shDefFileExt);
            index2.Value = Convert.ToDecimal(appinfo.Default.teDefFileExt);
        }
    }
}
