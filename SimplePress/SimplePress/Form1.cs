using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimplePress
{
    public partial class SimplePress : Form
    {
        public SimplePress()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            mainBox.SelectionFont = new Font("Verdana", sizeSld.Value, FontStyle.Regular);
        }

        private void sizeSld_Scroll(object sender, EventArgs e)
        {
            string lblValue = "" + sizeSld.Value;
            mainBox.SelectionFont = new Font(fntName.Text, sizeSld.Value, FontStyle.Regular);
            mainBox.SelectionFont = new Font(fntName.Text, sizeSld.Value, FontStyle.Regular);
            sizeLbl.Text = lblValue;
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            System.IO.Directory.CreateDirectory("c:\\SimplePress");
            mainBox.SaveFile("C:\\SimplePress\\" + docName.Text + ".rtf");
        }

        private void fontChoice_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {
            ColorDialog textColor = new ColorDialog();
            textColor.Color = mainBox.ForeColor;
            if (textColor.ShowDialog() == DialogResult.OK)
                mainBox.SelectionColor = textColor.Color;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FontDialog textFont = new FontDialog();
            textFont.Font = mainBox.Font;
            if (textFont.ShowDialog() == DialogResult.OK)
                mainBox.SelectionFont = textFont.Font;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Create an OpenFileDialog to request a file to open.
            OpenFileDialog openFile1 = new OpenFileDialog();

            // Initialize the OpenFileDialog to look for RTF files.
            openFile1.DefaultExt = "*.rtf";
            openFile1.Filter = "RTF Files|*.rtf";

            // Determine whether the user selected a file from the OpenFileDialog.
            if (openFile1.ShowDialog() == System.Windows.Forms.DialogResult.OK &&
               openFile1.FileName.Length > 0)
            {
                // Load the contents of the file into the RichTextBox.
                mainBox.LoadFile(openFile1.FileName);

            }
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            mainBox.SelectionFont = new Font(fntName.Text, sizeSld.Value, FontStyle.Regular);
        }
    }
}
