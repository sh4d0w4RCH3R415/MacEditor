using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

using Timer = System.Windows.Forms.Timer;

namespace MacEditor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// The file path for the TextEditor.
        /// </summary>
        private string FileDirectory = "";
        /// <summary>
        /// The file path for the Syntax Highlighter.
        /// </summary>
        private string ffileDirectory = "";

        #region Loading Stuffs
        private void Form1_Load(object sender, EventArgs e)
        {
            Timer timer = new Timer();
            timer.Interval = 10;
            timer.Tick += Timer_Tick;
            timer.Start();
            appinfo.Default.SettingChanging += Default_SettingChanging;
            texteditor.Font = appinfo.Default.teFont;
            texteditor.TabIndent = appinfo.Default.teTabIndent;
            syntaxeditor.Font = appinfo.Default.shFont;
        }

        private void Default_SettingChanging(object sender, SettingChangingEventArgs sce)
        {
            texteditor.TabIndent = appinfo.Default.teTabIndent;
            texteditor.Font = appinfo.Default.teFont;
            keywordColor.Text = "Keyword: " + appinfo.Default.shKeyword.Name;
            typeColor.Text = "Type: " + appinfo.Default.shType.Name;
            commentColor.Text = "Comment: " + appinfo.Default.shComment.Name;
            stringColor.Text = "String: " + appinfo.Default.shString.Name;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            currentFont.Text = "Current Font: " + texteditor.Font.Name + ", " + texteditor.Font.Size.ToString() + "pt";
            currentTabIndent.Text = "Tab Indent: " + texteditor.TabIndent.ToString();
            currentFont.Text = "Current Font: " + texteditor.Font.Name + ", " + texteditor.Font.Size.ToString() + "pt";
            currentTabIndent.Text = "Tab Indent: " + texteditor.TabIndent.ToString();
            currentFont.Text = "Current Font: " + texteditor.Font.Name + ", " + texteditor.Font.Size.ToString() + "pt";
            currentTabIndent.Text = "Tab Indent: " + texteditor.TabIndent.ToString();
            currentFont.Text = "Current Font: " + texteditor.Font.Name + ", " + texteditor.Font.Size.ToString() + "pt";
            currentTabIndent.Text = "Tab Indent: " + texteditor.TabIndent.ToString();
            keywordColor.Text = "Keyword: " + appinfo.Default.shKeyword.Name;
            typeColor.Text = "Type: " + appinfo.Default.shType.Name;
            commentColor.Text = "Comment: " + appinfo.Default.shComment.Name;
            stringColor.Text = "String: " + appinfo.Default.shString.Name;
        }
        #endregion
        #region File Opening & Saving - Text Editor
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            ofd.Title = "Open A File";
            ofd.Filter = "Text File|*.txt|Any File|*.*";
            ofd.FilterIndex = appinfo.Default.teDefFileExt;
            
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                StreamReader sr = new StreamReader(ofd.FileName);
                texteditor.Text = sr.ReadToEnd();
                FileDirectory = ofd.FileName;
                file.Text = "File: " + FileDirectory;
                sr.Close();
            }
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (texteditor.Text == "" || texteditor.Text == "" && file.Text.Contains("File: ") == true && FileDirectory != "")
            {
                file.Text = "(New File)";
                FileDirectory = "";
            }
            else if (texteditor.Text != "")
            {
                DialogResult Reminder = MessageBox.Show("Are you sure you'd like to continue without saving?\nIf you continue, you will lose everything and you won't be able to recover any of it.\n\n[Yes] - [No]", "Warning: Unsaved Changes", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (Reminder == DialogResult.Yes)
                    texteditor.Text = "";
                else if (Reminder == DialogResult.No)
                {
                    SaveFileDialog sfd = new SaveFileDialog();

                    sfd.Title = "Save File";
                    sfd.Filter = "Text File|*.txt|Any File|*.*";
                    sfd.FilterIndex = appinfo.Default.teDefFileExt;

                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        StreamWriter sw = new StreamWriter(sfd.FileName);
                        sw.Write(texteditor.Text);
                        FileDirectory = sfd.FileName;
                        file.Text = "File: " + FileDirectory;
                        sw.Close();
                    }
                }
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (file.Text == "(New File)" && FileDirectory == "" && texteditor.Text == "" || file.Text == "(New File)" && FileDirectory == "" && texteditor.Text != "")
            {
                SaveFileDialog sfd = new SaveFileDialog();

                sfd.Title = "Save File";
                sfd.Filter = "Text File|*.txt|Any File|*.*";
                sfd.FilterIndex = appinfo.Default.teDefFileExt;

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    StreamWriter sw = new StreamWriter(sfd.FileName);
                    sw.Write(texteditor.Text);
                    FileDirectory = sfd.FileName;
                    file.Text = "File: " + FileDirectory;
                    sw.Close();
                }
            }
            else if (file.Text.Contains("File: ") == true && FileDirectory != "")
            {
                StreamWriter sw = new StreamWriter(FileDirectory);
                sw.Write(texteditor.Text);
                file.Text = "File: " + FileDirectory;
                sw.Close();
            }
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();

            sfd.Title = "Save File As";
            sfd.Filter = "Text File|*.txt|Any File|*.*";
            sfd.FilterIndex = appinfo.Default.teDefFileExt;

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                StreamWriter sw = new StreamWriter(sfd.FileName);
                sw.Write(texteditor.Text);
                FileDirectory = sfd.FileName;
                file.Text = "File: " + FileDirectory;
                sw.Close();
            }
        }
        #endregion
        #region File Opening & Saving - Syntax Highlighter
        private void openToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            ofd.Title = "Open A File";
            ofd.Filter = "Text File|*.txt|Any File|*.*";
            ofd.FilterIndex = appinfo.Default.shDefFileExt;

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                StreamReader sr = new StreamReader(ofd.FileName);
                syntaxeditor.Text = sr.ReadToEnd();
                ffileDirectory = ofd.FileName;
                ffile.Text = "File: " + ffileDirectory;
                sr.Close();
            }
        }

        private void newToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (syntaxeditor.Text == "" || syntaxeditor.Text == "" && ffile.Text.Contains("File: ") == true && ffileDirectory != "")
            {
                ffile.Text = "(New File)";
                ffileDirectory = "";
            }
            else if (syntaxeditor.Text != "")
            {
                DialogResult Reminder = MessageBox.Show("Are you sure you'd like to continue without saving?\nIf you continue, you will lose everything and you won't be able to recover any of it.\n\n[Yes] - [No]", "Warning: Unsaved Changes", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (Reminder == DialogResult.Yes)
                    syntaxeditor.Text = "";
                else if (Reminder == DialogResult.No)
                {
                    SaveFileDialog sfd = new SaveFileDialog();

                    sfd.Title = "Save File";
                    sfd.Filter = "Text File|*.txt|Any File|*.*";
                    sfd.FilterIndex = appinfo.Default.shDefFileExt;

                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        StreamWriter sw = new StreamWriter(sfd.FileName);
                        sw.Write(syntaxeditor.Text);
                        ffileDirectory = sfd.FileName;
                        ffile.Text = "File: " + ffileDirectory;
                        sw.Close();
                    }
                }
            }
        }

        private void saveToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (ffile.Text == "(New File)" && ffileDirectory == "" && syntaxeditor.Text == "" || ffile.Text == "(New File)" && ffileDirectory == "" && syntaxeditor.Text != "")
            {
                SaveFileDialog sfd = new SaveFileDialog();

                sfd.Title = "Save File";
                sfd.Filter = "Text File|*.txt|Any File|*.*";
                sfd.FilterIndex = appinfo.Default.shDefFileExt;

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    StreamWriter sw = new StreamWriter(sfd.FileName);
                    sw.Write(syntaxeditor.Text);
                    ffileDirectory = sfd.FileName;
                    ffile.Text = "File: " + ffileDirectory;
                    sw.Close();
                }
            }
            else if (ffile.Text.Contains("File: ") == true && ffileDirectory != "")
            {
                StreamWriter sw = new StreamWriter(ffileDirectory);
                sw.Write(syntaxeditor.Text);
                ffile.Text = "File: " + ffileDirectory;
                sw.Close();
            }
        }

        private void saveAsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();

            sfd.Title = "Save File As";
            sfd.Filter = "Text File|*.txt|Any File|*.*";
            sfd.FilterIndex = appinfo.Default.shDefFileExt;

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                StreamWriter sw = new StreamWriter(sfd.FileName);
                sw.Write(syntaxeditor.Text);
                ffileDirectory = sfd.FileName;
                ffile.Text = "File: " + ffileDirectory;
                sw.Close();
            }
        }
        #endregion
        #region DialogBoxes
        private void tabIndentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TabIndentChange tic = new TabIndentChange();
            tic.ShowDialog();
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TextEditorFont tef = new TextEditorFont();
            tef.ShowDialog();
        }

        private void fontToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SyntaxHighlighterFont shf = new SyntaxHighlighterFont();
            shf.ShowDialog();
        }
        #endregion
        #region Syntax Color Editing
        private void keywordColor_Click(object sender, EventArgs e)
        {
            ColorChangerHelper.IsKeyWordDialog = true;
            ColorChangerHelper.IsCommentDialog = false;
            ColorChangerHelper.IsStringDialog = false;
            ColorChangerHelper.IsTypeDialog = false;
            ColorChanger cc = new ColorChanger();
            cc.ShowDialog();
        }

        private void typeColor_Click(object sender, EventArgs e)
        {
            ColorChangerHelper.IsTypeDialog = true;
            ColorChangerHelper.IsKeyWordDialog = false;
            ColorChangerHelper.IsCommentDialog = false;
            ColorChangerHelper.IsStringDialog = false;
            ColorChanger cc = new ColorChanger();
            cc.ShowDialog();
        }

        private void commentColor_Click(object sender, EventArgs e)
        {
            ColorChangerHelper.IsCommentDialog = true;
            ColorChangerHelper.IsTypeDialog = false;
            ColorChangerHelper.IsKeyWordDialog = false;
            ColorChangerHelper.IsStringDialog = false;
            ColorChanger cc = new ColorChanger();
            cc.ShowDialog();
        }

        private void stringColor_Click(object sender, EventArgs e)
        {
            ColorChangerHelper.IsStringDialog = true;
            ColorChangerHelper.IsCommentDialog = false;
            ColorChangerHelper.IsTypeDialog = false;
            ColorChangerHelper.IsKeyWordDialog = false;
            ColorChanger cc = new ColorChanger();
            cc.ShowDialog();
        }
        #endregion
        #region Syntax Highlighting
        private void syntaxeditor_TextChanged(object sender, EventArgs e)
        {
            string keywords = @"\b(public|private|partial|static|namespace|class|using|void|foreach|in|for|return|var|int|value|bool|false|true|string|object|delegate|event|protected|internal|interface|struct)\b";
            MatchCollection keywordmatches = Regex.Matches(syntaxeditor.Text, keywords);

            string types = @"\b(Console|MessageBox|Math|String|Int32|Color|Attribute|Form|Exception|UserControl|Control|Label|LinkLabel|OpenFileDialog|SaveFileDialog|Button|Timer|Panel|TabControl|PictureBox|ComboBox|TextBox|RichTextBox|StatusStrip|ToolStrip|MenuStrip|ToolStripContainer|FlowLayoutPlanel|ColorDialog|FontDialog|ContextMenuStrip|NotifyIcon|Image|Icon|Graphics|EventArgs|PaintEventArgs|FormClosingEventArgs|EventHandler|FormClosingEventHandler|PaintEventHandler|EventHandler|Bitmap|Rectangle|Point|RectangleF|PointConverter|Convert|PointF|RectangleConverter|ColorConverter|Message|Size)\b";
            MatchCollection typematches = Regex.Matches(syntaxeditor.Text, types);

            string comments = @"(\/\/.+?$|\/\*.+?\*\/)";
            MatchCollection commentmatches = Regex.Matches(syntaxeditor.Text, comments, RegexOptions.Multiline);

            string strings = "\".+?\"";
            MatchCollection stringmatches = Regex.Matches(syntaxeditor.Text, strings, RegexOptions.Multiline);
            
            int originalIndex = syntaxeditor.SelectionStart;
            int originalLength = syntaxeditor.SelectionLength;
            Color originalColor = Color.Black;

            statusStrip4.Focus();

            syntaxeditor.SelectionStart = 0;
            syntaxeditor.SelectionLength = syntaxeditor.Text.Length;
            syntaxeditor.SelectionColor = originalColor;

            foreach (Match m in keywordmatches)
            {
                syntaxeditor.SelectionStart = m.Index;
                syntaxeditor.SelectionLength = m.Length;
                syntaxeditor.SelectionColor = appinfo.Default.shKeyword;
            }

            foreach (Match m in typematches)
            {
                syntaxeditor.SelectionStart = m.Index;
                syntaxeditor.SelectionLength = m.Length;
                syntaxeditor.SelectionColor = appinfo.Default.shType;
            }

            foreach (Match m in commentmatches)
            {
                syntaxeditor.SelectionStart = m.Index;
                syntaxeditor.SelectionLength = m.Length;
                syntaxeditor.SelectionColor = appinfo.Default.shComment;
            }

            foreach (Match m in stringmatches)
            {
                syntaxeditor.SelectionStart = m.Index;
                syntaxeditor.SelectionLength = m.Length;
                syntaxeditor.SelectionColor = appinfo.Default.shString;
            }

            syntaxeditor.SelectionStart = originalIndex;
            syntaxeditor.SelectionLength = originalLength;
            syntaxeditor.SelectionColor = originalColor;

            syntaxeditor.Focus();
        }
        #endregion
        #region Label Highlighting
        private Color BackColor(ToolStripStatusLabel Control, Color BackColor)
        {
            return Control.BackColor = BackColor;
        }

        private Color Dimmed = Color.FromName("WhiteSmoke");
        private Color Normal = Color.FromName("Window");

        private void keywordColor_MouseEnter(object sender, EventArgs e)
        {
            BackColor(keywordColor, Dimmed);
        }

        private void keywordColor_MouseLeave(object sender, EventArgs e)
        {
            BackColor(keywordColor, Normal);
        }

        private void typeColor_MouseEnter(object sender, EventArgs e)
        {
            BackColor(typeColor, Dimmed);
        }

        private void typeColor_MouseLeave(object sender, EventArgs e)
        {
            BackColor(typeColor, Normal);
        }

        private void commentColor_MouseEnter(object sender, EventArgs e)
        {
            BackColor(commentColor, Dimmed);
        }

        private void commentColor_MouseLeave(object sender, EventArgs e)
        {
            BackColor(commentColor, Normal);
        }

        private void stringColor_MouseEnter(object sender, EventArgs e)
        {
            BackColor(stringColor, Dimmed);
        }

        private void stringColor_MouseLeave(object sender, EventArgs e)
        {
            BackColor(stringColor, Normal);
        }
        #endregion
        #region Label1
        private Color _BackColor(Label Label, Color BackColor)
        {
            return Label.BackColor = BackColor;
        }

        private void label1_MouseEnter(object sender, EventArgs e)
        {
            _BackColor(label1, Color.FromName("Window"));
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            _BackColor(label1, Color.FromName("Control"));
        }

        private void label1_Click(object sender, EventArgs e)
        {
            DefaultFileExtensionIndex dfei = new DefaultFileExtensionIndex();
            dfei.ShowDialog();
        }
        #endregion
    }
}
