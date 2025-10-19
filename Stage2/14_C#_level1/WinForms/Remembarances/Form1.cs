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
        public  static string[] RemebarancesList =   {"لا إله إلا الله ","سبحان الله وبحمده","أستغفر الله وأتوب إليه","صلِ على محمد","لا حول ولا قوة إلا بالله","سبحان الله العظيم ","سبحان الله ","الحمدلله ","الله أكبر","اللهم أنت ربي لا إله إلا أنت خلقتني وأنا عبدك وأنا على عهدك ووعدك ما استطعت أعوذ بك من شر ما صنعت أبوء لك بنعمتك علي وأبوء بذنبي فاغفر لك فإنه لا يغفر الذنوب إلا أنت "};
        Random rnd = new Random();

        private void timer1_Tick(object sender, EventArgs e)
        {
            notifyIcon1.Icon = SystemIcons.Application;
            notifyIcon1.ShowBalloonTip(10,"لا تنسى ذكر الله ",RemebarancesList[rnd.Next(0,RemebarancesList.Length-1)],ToolTipIcon.Info);

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
             }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Interval = Convert.ToInt32(maskedTextBox1.Text) * 60000;
            MessageBox.Show($"سيتم ارسال اشعار كل {timer1.Interval}");

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
           Form frm = new frmTspeeh();
            frm.Show();
        }

        private void btnMyRemebarances_Click(object sender, EventArgs e)
        {
            Form frm = new frmMyRemembarnces();
            frm.Show();

        }
    }
}
