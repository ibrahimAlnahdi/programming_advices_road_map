using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace myFirstWinFormProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox3.Text = textBox1.Text;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox3.Text = textBox1.Text;
            label1.Text = textBox1.Text;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Enabled = false;
        }

        private void button_Click(object sender, EventArgs e)
        {
            textBox1.Enabled = true;

        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Visible = false;
            // swich bettwen hide show
            //textBox1.Enabled = textBox1.Enabled ? false : true;

        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Visible = true;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Red;  //? this.BackColor = Color.Red : this.BackColor = Color.Green;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
        }

        private void Mouse_Enter(object sender, EventArgs e)
        {
            textBox3.Text = textBox1.Text;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure , you want to Exit ? ", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question,MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                this.Close();

        }
    }
}
