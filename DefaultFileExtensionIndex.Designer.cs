namespace MacEditor
{
    partial class DefaultFileExtensionIndex
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DefaultFileExtensionIndex));
            this.button1 = new System.Windows.Forms.Button();
            this.index1 = new System.Windows.Forms.NumericUpDown();
            this.index2 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.index1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.index2)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(5, 53);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(152, 21);
            this.button1.TabIndex = 1;
            this.button1.Text = "Done";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // index1
            // 
            this.index1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.index1.Location = new System.Drawing.Point(90, 6);
            this.index1.Maximum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.index1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.index1.Name = "index1";
            this.index1.Size = new System.Drawing.Size(67, 20);
            this.index1.TabIndex = 2;
            this.index1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // index2
            // 
            this.index2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.index2.Location = new System.Drawing.Point(90, 30);
            this.index2.Maximum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.index2.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.index2.Name = "index2";
            this.index2.Size = new System.Drawing.Size(67, 20);
            this.index2.TabIndex = 3;
            this.index2.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Syntax Editor:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Text Editor:";
            // 
            // DefaultFileExtensionIndex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(162, 79);
            this.ControlBox = false;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.index2);
            this.Controls.Add(this.index1);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DefaultFileExtensionIndex";
            this.ShowIcon = false;
            this.Text = "Default File Extension Index";
            this.Load += new System.EventHandler(this.DefaultFileExtensionIndex_Load);
            ((System.ComponentModel.ISupportInitialize)(this.index1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.index2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown index1;
        private System.Windows.Forms.NumericUpDown index2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}