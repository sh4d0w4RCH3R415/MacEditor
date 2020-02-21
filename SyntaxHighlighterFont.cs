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
    public partial class SyntaxHighlighterFont : Form
    {
        public SyntaxHighlighterFont()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FontDialog fd = new FontDialog();

            if (fd.ShowDialog() == DialogResult.OK)
            {
                fontName.Text = fd.Font.Name;
                fontSize.Value = Convert.ToDecimal(fd.Font.Size);
                appinfo.Default.shFont = new Font(fontName.Text, (float)Convert.ToDouble(fontSize.Value));
                appinfo.Default.Save();
            }
        }

        private void fontName_TextChanged(object sender, EventArgs e)
        {
            try
            {
                appinfo.Default.shFont = new Font(fontName.Text, (float)Convert.ToDouble(fontSize.Value));
                appinfo.Default.Save();
            } catch {}
        }

        private void fontSize_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                appinfo.Default.shFont = new Font(fontName.Text, (float)Convert.ToDouble(fontSize.Value));
                appinfo.Default.Save();
            }
            catch { }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            appinfo.Default.Save();
            Close();
        }

        private void SyntaxHighlighterFont_Load(object sender, EventArgs e)
        {
            fontName.Text = appinfo.Default.shFont.Name;
            fontSize.Value = Convert.ToDecimal(appinfo.Default.shFont.Size);
        }
    }
}
