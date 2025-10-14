using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Remembarances
{
    public partial class frmTspeeh : Form
    {
        public frmTspeeh()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmTspeeh_Load(object sender, EventArgs e)
        {


        }
        private byte counter = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            button1.Enabled = false;
            lblProgressBarValue.Visible = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            counter++;
            if (counter <= 33)
            {
                label1.ForeColor = Color.BlueViolet;
                label1.Text = $"سبحان الله - {counter}";
            }
            else if (counter <= 66)
            {
                label1.ForeColor = Color.Green;

                label1.Text = $"الحمد الله - {counter - 33}";
            }
            else if (counter <= 99)
            {
                label1.ForeColor = Color.DarkRed;

                label1.Text = $" الله أكبر - {counter - 66}";
            }
            else if (counter == 100)
            {
                label1.ForeColor = Color.DarkMagenta;

                label1.Text = "لا إله الله وحده لا شريك له له الملك وله الحمد وهو على كل شيء قدير";
            }
            else if (counter == 105)
            {
                label1.ForeColor = Color.Black;
                label1.Text = "والذاكرين الله كثيرًا والذاكرات ";
                timer1.Enabled = false;
                counter = 0;
                button1.Enabled = true;
               
            }
            if (counter <= 100 && counter >= 0)
            {
                progressBar1.Value = counter;
                lblProgressBarValue.Text = counter.ToString() + "%";

            }
        }
    }
}
