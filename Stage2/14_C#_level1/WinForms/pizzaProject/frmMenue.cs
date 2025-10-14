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
    public partial class frmMenue : Form
    {
        public frmMenue()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (byte i = 0; i < 5; i++)
            {
                checkedListBox1.Items.Add("item " + i);
            }
        }

        private void btnRemove3thItem_Click(object sender, EventArgs e)
        {
            if (checkedListBox1.Items.Count >= 3)
            {
                checkedListBox1.Items.RemoveAt(2);

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            for (byte i = 0; i < checkedListBox1.CheckedItems.Count; i++)
            {
                MessageBox.Show(checkedListBox1.CheckedItems[i].ToString());
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            for (byte i = 0; i < checkedListBox1.Items.Count; i++)
            {
                checkedListBox1.SetItemChecked(i, true);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            for (byte i = 0; i < checkedListBox1.Items.Count; i++)
            {
                checkedListBox1.SetItemChecked(i, false);
            }
        }
    }
}
