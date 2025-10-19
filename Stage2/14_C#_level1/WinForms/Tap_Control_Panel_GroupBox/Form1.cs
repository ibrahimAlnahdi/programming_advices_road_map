using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tap_Control_Panel_GroupBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                panel1.BackColor = colorDialog1.Color;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                FlagTop.BackColor = colorDialog1.Color;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                flagCenter.BackColor = colorDialog1.Color;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                flagBottom.BackColor = colorDialog1.Color;
            }
        }

        private void btnChangeFont_Click(object sender, EventArgs e)
        {
            fontDialog1.Font = textBox1.Font;
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox1.Font = fontDialog1.Font;
                textBox1.ForeColor = fontDialog1.Color;
            }
        }

        private void fontDialog1_Apply(object sender, EventArgs e)
        {
            textBox1.Font = fontDialog1.Font;
            textBox1.ForeColor = fontDialog1.Color;

        }

        private void btnSaveFile_Click(object sender, EventArgs e)
        {
            saveFileDialog1.InitialDirectory = @"D:\";
            saveFileDialog1.Title = "KOKO";
            saveFileDialog1.DefaultExt = "txt";
            saveFileDialog1.Filter = "Text Files |*.txt| All Files  |*.*| JPG Files |*.jpg";
            saveFileDialog1.FilterIndex = 2;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show(saveFileDialog1.FileName);
            }
        }

        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = @"C:\";
            openFileDialog1.Filter = "All |*.*";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private void btnMultiSelcetOpenFile_Click(object sender, EventArgs e)
        {
            openFileDialog1.Multiselect = true;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                foreach (String file in openFileDialog1.FileNames)
                {
                    MessageBox.Show(file);
                }
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowNewFolderButton = true;

            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show(folderBrowserDialog1.SelectedPath);
            }
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            frm2.MdiParent = this;
            frm2.Show();
        }
    }
}
