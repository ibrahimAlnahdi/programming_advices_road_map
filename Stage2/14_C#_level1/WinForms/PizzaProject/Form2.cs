using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using pizzaProject;
namespace pizzaProject
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnPorgar_CheckedChanged(object sender, EventArgs e)
        {
            // if (btnPorgar.Checked)
            pictureBox1.Image = Properties.Resources.Porger1;
            lblTitle.Text = ((RadioButton)sender).Text;

        }

        private void btnShaorma_CheckedChanged(object sender, EventArgs e)
        {
            //if (btnShaorma.Checked)
             pictureBox1.Image = Properties.Resources.shawarma2;
            lblTitle.Text = ((RadioButton)sender).Text;

        }

        private void rdFlafel_CheckedChanged(object sender, EventArgs e)
        {
            //if (rdFlafel.Checked)
            pictureBox1.Image = Properties.Resources.Falafel1;
            lblTitle.Text = (((RadioButton)sender).Text);

        }

        private void rdFrise_CheckedChanged(object sender, EventArgs e)
        {
            //if (rdFrise.Checked)
            pictureBox1.Image = Properties.Resources.Fries2;

            lblTitle.Text = ((RadioButton)sender).Text;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //MessageBox.Show(comboBox1.Text);
            switch (comboBox1.Text)
            {
                case "Falafel":
                    pictureBox1.Image = Properties.Resources.Falafel1;
                    break;
                case "Purgar":
                    pictureBox1.Image = Properties.Resources.Porger1;
                    break;
                case "Shawarma":
                    pictureBox1.Image = Properties.Resources.shawarma2;
                    break;
                case "Fries":
                    pictureBox1.Image = Properties.Resources.Fries2;
                    break;
                default:
                    pictureBox1.Image = Properties.Resources.fastFood2;
                    break;
            }
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {
           // comboBox1.SelectedIndex = 0;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
