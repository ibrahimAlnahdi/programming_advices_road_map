using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MDI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Form2 form2 = new Form2();
        private void button1_Click(object sender, EventArgs e)
        {
            form2.MdiParent = this;
            form2.Show();
        }

        private void byUserNamePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void addNewClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddClient frmAddClient = new frmAddClient();
            frmAddClient.MdiParent = this;  
            frmAddClient.Show();
        }
    }
}
