namespace SimplePress
{
    partial class SimplePress
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SimplePress));
            this.mainBox = new System.Windows.Forms.RichTextBox();
            this.saveBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.sizeSld = new System.Windows.Forms.TrackBar();
            this.sizeLbl = new System.Windows.Forms.Label();
            this.docName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.fntName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.sizeSld)).BeginInit();
            this.SuspendLayout();
            // 
            // mainBox
            // 
            this.mainBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainBox.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainBox.Location = new System.Drawing.Point(12, 74);
            this.mainBox.Name = "mainBox";
            this.mainBox.Size = new System.Drawing.Size(1074, 482);
            this.mainBox.TabIndex = 0;
            this.mainBox.Text = "";
            // 
            // saveBtn
            // 
            this.saveBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.saveBtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.saveBtn.Location = new System.Drawing.Point(1039, 12);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(48, 23);
            this.saveBtn.TabIndex = 1;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(205, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Size (Pt.)";
            // 
            // sizeSld
            // 
            this.sizeSld.BackColor = System.Drawing.Color.CornflowerBlue;
            this.sizeSld.Location = new System.Drawing.Point(277, 14);
            this.sizeSld.Maximum = 70;
            this.sizeSld.Minimum = 1;
            this.sizeSld.Name = "sizeSld";
            this.sizeSld.Size = new System.Drawing.Size(132, 56);
            this.sizeSld.TabIndex = 5;
            this.sizeSld.Value = 12;
            this.sizeSld.Scroll += new System.EventHandler(this.sizeSld_Scroll);
            // 
            // sizeLbl
            // 
            this.sizeLbl.AutoSize = true;
            this.sizeLbl.BackColor = System.Drawing.Color.Transparent;
            this.sizeLbl.Location = new System.Drawing.Point(328, 53);
            this.sizeLbl.Name = "sizeLbl";
            this.sizeLbl.Size = new System.Drawing.Size(24, 17);
            this.sizeLbl.TabIndex = 6;
            this.sizeLbl.Text = "12";
            this.sizeLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // docName
            // 
            this.docName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.docName.Location = new System.Drawing.Point(877, 42);
            this.docName.Name = "docName";
            this.docName.Size = new System.Drawing.Size(208, 22);
            this.docName.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(874, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Name of Doc:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button1.Location = new System.Drawing.Point(415, 24);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(51, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Color";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button3.Location = new System.Drawing.Point(981, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(52, 23);
            this.button3.TabIndex = 12;
            this.button3.Text = "Open";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(12, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "Font";
            // 
            // fntName
            // 
            this.fntName.AutoCompleteCustomSource.AddRange(new string[] {
            "Arial",
            "Calibri",
            "Cambria",
            "Didot",
            "Garamond",
            "Vernada",
            "Georgia",
            "Helvetica",
            "Times New Roman",
            "Trebuchet MS",
            "Bell MT",
            "Book Antiqua",
            "Century Gothic"});
            this.fntName.Location = new System.Drawing.Point(54, 25);
            this.fntName.Name = "fntName";
            this.fntName.Size = new System.Drawing.Size(144, 22);
            this.fntName.TabIndex = 14;
            this.fntName.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // SimplePress
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1099, 568);
            this.Controls.Add(this.fntName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.docName);
            this.Controls.Add(this.sizeLbl);
            this.Controls.Add(this.sizeSld);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.mainBox);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(730, 240);
            this.Name = "SimplePress";
            this.Text = "SimplePress";
            ((System.ComponentModel.ISupportInitialize)(this.sizeSld)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox mainBox;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar sizeSld;
        private System.Windows.Forms.Label sizeLbl;
        private System.Windows.Forms.TextBox docName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox fntName;
    }
}

