namespace Activity_14
{
    partial class Form1
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
            this.fontStyleReg = new System.Windows.Forms.RadioButton();
            this.fontStyleObl = new System.Windows.Forms.RadioButton();
            this.fontStyleBold = new System.Windows.Forms.RadioButton();
            this.fontStyleBoldObl = new System.Windows.Forms.RadioButton();
            this.strikeOut = new System.Windows.Forms.CheckBox();
            this.underline = new System.Windows.Forms.CheckBox();
            this.fontsListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // fontStyleReg
            // 
            this.fontStyleReg.AutoSize = true;
            this.fontStyleReg.Location = new System.Drawing.Point(9, 32);
            this.fontStyleReg.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.fontStyleReg.Name = "fontStyleReg";
            this.fontStyleReg.Size = new System.Drawing.Size(62, 17);
            this.fontStyleReg.TabIndex = 0;
            this.fontStyleReg.TabStop = true;
            this.fontStyleReg.Text = "Regular";
            this.fontStyleReg.UseVisualStyleBackColor = true;
            this.fontStyleReg.CheckedChanged += new System.EventHandler(this.fontControl);
            // 
            // fontStyleObl
            // 
            this.fontStyleObl.AutoSize = true;
            this.fontStyleObl.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic);
            this.fontStyleObl.Location = new System.Drawing.Point(9, 54);
            this.fontStyleObl.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.fontStyleObl.Name = "fontStyleObl";
            this.fontStyleObl.Size = new System.Drawing.Size(61, 17);
            this.fontStyleObl.TabIndex = 1;
            this.fontStyleObl.TabStop = true;
            this.fontStyleObl.Text = "Oblique";
            this.fontStyleObl.UseVisualStyleBackColor = true;
            this.fontStyleObl.CheckedChanged += new System.EventHandler(this.fontControl);
            // 
            // fontStyleBold
            // 
            this.fontStyleBold.AutoSize = true;
            this.fontStyleBold.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fontStyleBold.Location = new System.Drawing.Point(9, 75);
            this.fontStyleBold.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.fontStyleBold.Name = "fontStyleBold";
            this.fontStyleBold.Size = new System.Drawing.Size(50, 17);
            this.fontStyleBold.TabIndex = 2;
            this.fontStyleBold.TabStop = true;
            this.fontStyleBold.Text = "Bold";
            this.fontStyleBold.UseVisualStyleBackColor = true;
            this.fontStyleBold.CheckedChanged += new System.EventHandler(this.fontControl);
            // 
            // fontStyleBoldObl
            // 
            this.fontStyleBoldObl.AutoSize = true;
            this.fontStyleBoldObl.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fontStyleBoldObl.Location = new System.Drawing.Point(9, 96);
            this.fontStyleBoldObl.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.fontStyleBoldObl.Name = "fontStyleBoldObl";
            this.fontStyleBoldObl.Size = new System.Drawing.Size(97, 17);
            this.fontStyleBoldObl.TabIndex = 3;
            this.fontStyleBoldObl.TabStop = true;
            this.fontStyleBoldObl.Text = "Bold Oblique";
            this.fontStyleBoldObl.UseVisualStyleBackColor = true;
            this.fontStyleBoldObl.CheckedChanged += new System.EventHandler(this.fontControl);
            // 
            // strikeOut
            // 
            this.strikeOut.AutoSize = true;
            this.strikeOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Strikeout, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.strikeOut.Location = new System.Drawing.Point(9, 152);
            this.strikeOut.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.strikeOut.Name = "strikeOut";
            this.strikeOut.Size = new System.Drawing.Size(68, 17);
            this.strikeOut.TabIndex = 4;
            this.strikeOut.Text = "Strikeout";
            this.strikeOut.UseVisualStyleBackColor = true;
            this.strikeOut.CheckedChanged += new System.EventHandler(this.fontControl);
            // 
            // underline
            // 
            this.underline.AutoSize = true;
            this.underline.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.underline.Location = new System.Drawing.Point(9, 173);
            this.underline.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.underline.Name = "underline";
            this.underline.Size = new System.Drawing.Size(71, 17);
            this.underline.TabIndex = 5;
            this.underline.Text = "Underline";
            this.underline.UseVisualStyleBackColor = true;
            this.underline.CheckedChanged += new System.EventHandler(this.fontControl);
            // 
            // fontsListBox
            // 
            this.fontsListBox.FormattingEnabled = true;
            this.fontsListBox.Items.AddRange(new object[] {
            "Agency FB",
            "Algerian",
            "Aurebesh",
            "Bahnschrift",
            "Broadway",
            "Calibri",
            "Comic Sans MS",
            "Times New Roman",
            "Trebuchet MS",
            "Microsoft Tai Le",
            "Microsoft Sans Serif"});
            this.fontsListBox.Location = new System.Drawing.Point(9, 228);
            this.fontsListBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.fontsListBox.Name = "fontsListBox";
            this.fontsListBox.Size = new System.Drawing.Size(110, 82);
            this.fontsListBox.TabIndex = 8;
            this.fontsListBox.SelectedIndexChanged += new System.EventHandler(this.fontControl);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Font Styles";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 124);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Effects";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 201);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Fonts";
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(147, 29);
            this.textBox.Multiline = true;
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(216, 281);
            this.textBox.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 330);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fontsListBox);
            this.Controls.Add(this.underline);
            this.Controls.Add(this.strikeOut);
            this.Controls.Add(this.fontStyleBoldObl);
            this.Controls.Add(this.fontStyleBold);
            this.Controls.Add(this.fontStyleObl);
            this.Controls.Add(this.fontStyleReg);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton fontStyleReg;
        private System.Windows.Forms.RadioButton fontStyleObl;
        private System.Windows.Forms.RadioButton fontStyleBold;
        private System.Windows.Forms.RadioButton fontStyleBoldObl;
        private System.Windows.Forms.CheckBox strikeOut;
        private System.Windows.Forms.CheckBox underline;
        private System.Windows.Forms.ListBox fontsListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox;
    }
}

