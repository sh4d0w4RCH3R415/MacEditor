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
    public partial class ColorChanger : Form
    {
        public ColorChanger()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();

            if (cd.ShowDialog() == DialogResult.OK)
            {
                if (ColorChangerHelper.IsCommentDialog == true)
                {
                    appinfo.Default.shComment = cd.Color;
                    appinfo.Default.Save();
                }
                else if (ColorChangerHelper.IsKeyWordDialog == true)
                {
                    appinfo.Default.shKeyword = cd.Color;
                    appinfo.Default.Save();
                }
                else if (ColorChangerHelper.IsStringDialog == true)
                {
                    appinfo.Default.shString = cd.Color;
                    appinfo.Default.Save();
                }
                else if (ColorChangerHelper.IsTypeDialog == true)
                {
                    appinfo.Default.shType = cd.Color;
                    appinfo.Default.Save();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            appinfo.Default.Save();
            DialogResult restartapp = MessageBox.Show("Changes were made to the Syntax Highlighter's colors. A restart is needed to apply them.", "Application Restart Required", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            if (restartapp == DialogResult.OK)
                Application.Restart();
        }

        private void simpleColors_SelectedValueChanged(object sender, EventArgs e)
        {
            if (ColorChangerHelper.IsCommentDialog == true)
            {
                appinfo.Default.shComment = Color.FromName(simpleColors.SelectedItem.ToString());
                appinfo.Default.Save();
            }
            else if (ColorChangerHelper.IsKeyWordDialog == true)
            {
                appinfo.Default.shKeyword = Color.FromName(simpleColors.SelectedItem.ToString());
                appinfo.Default.Save();
            }
            else if (ColorChangerHelper.IsStringDialog == true)
            {
                appinfo.Default.shString = Color.FromName(simpleColors.SelectedItem.ToString());
                appinfo.Default.Save();
            }
            else if (ColorChangerHelper.IsTypeDialog == true)
            {
                appinfo.Default.shType = Color.FromName(simpleColors.SelectedItem.ToString());
                appinfo.Default.Save();
            }
        }
    }
}
