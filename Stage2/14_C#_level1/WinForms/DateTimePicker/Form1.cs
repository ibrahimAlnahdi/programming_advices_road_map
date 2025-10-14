using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DateTimePicker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            label1.Text = dateTimePicker1.Text+ Environment.NewLine;
            label1.Text += dateTimePicker1.Value.ToString("dd-MMM-yyyy")+ Environment.NewLine;
            label1.Text += dateTimePicker1.Value.ToString("dddd-MMM-yyyy") + Environment.NewLine;
            label1.Text += dateTimePicker1.Value.ToString("mm-dd-yyyy") + Environment.NewLine;
            label1.Text += dateTimePicker1.Value.ToString("dd/mm/yy") + Environment.NewLine;
            label1.Text += dateTimePicker1.Value.ToString("dddd, dd-mmm-yyyy") + Environment.NewLine;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(dateTimePicker1.Value.ToShortDateString(), "Date");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(dateTimePicker1.Value.ToLongDateString(), "Date");

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(monthCalendar1.SelectionStart.ToString());

        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show(monthCalendar1.SelectionEnd.ToString());

        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show(monthCalendar1.SelectionRange.ToString());

        }

        private void button6_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            label2.Visible = true;
        }
        private int counter = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            counter++;
            label2.Text = counter.ToString();

        }
    }
}
