using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pizzaProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form form = new frmOrderPizza();
            if (txtUserName.Text == "Admin" && "Admin" == txtPassword.Text)
            {
                form.ShowDialog();

            }
            else
                MessageBox.Show("Wrong User Name / Password","Wrong",MessageBoxButtons.OK,MessageBoxIcon.Error);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnOtherProducts_Click(object sender, EventArgs e)
        {
            Form form = new Form2();
            form.ShowDialog();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel1.LinkVisited = true;
            System.Diagnostics.Process.Start("https://ProgrammingAdvices.com"); 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form form = new frmMenue();
            form.ShowDialog(); 
        }
    }
}
