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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private string[] Remembarances =   {"لا إله إلا الله ","سبحان الله وبحمده","أستغفر الله وأتوب إليه","صلِ على محمد","لا حول ولا قوة إلا بالله"};
        Random rnd = new Random();

        private void timer1_Tick(object sender, EventArgs e)
        {
            notifyIcon1.Icon = SystemIcons.Application;
            notifyIcon1.ShowBalloonTip(10,"لا تنسى ذكر الله ",Remembarances[rnd.Next(0,4)],ToolTipIcon.Info);

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
             }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Interval = Convert.ToInt32(maskedTextBox1.Text) * 60000;
            MessageBox.Show($"سيتم ارسال اشعار كل {timer1.Interval}");

        }
    }
}
