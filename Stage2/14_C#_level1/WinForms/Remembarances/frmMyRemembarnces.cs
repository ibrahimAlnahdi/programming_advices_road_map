using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Remembarances;
namespace Remembarances
{
    public partial class frmMyRemembarnces : Form
    {
        public frmMyRemembarnces()
        {
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtID.Text) || string.IsNullOrEmpty(txtTheker.Text))
                return;
            ListViewItem item = new ListViewItem(txtID.Text.Trim());
            if (rdDoa.Checked)
                item.ImageIndex = 0;
            else
                item.ImageIndex = 1;
            item.SubItems.Add(txtTheker.Text.Trim());
            listView1.Items.Add(item);
            txtID.Clear();
            txtTheker.Clear();
            txtID.Focus();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (listView1.Items.Count > 0)
            {
                listView1.Items.Remove(listView1.SelectedItems[0]);

            }
        }

        private void rdLargeIcone_CheckedChanged(object sender, EventArgs e)
        {
            listView1.View = View.LargeIcon;
        }

        private void rdSmallIcon_CheckedChanged(object sender, EventArgs e)
        {
            listView1.View = View.SmallIcon;
        }

        private void rdDetails_CheckedChanged(object sender, EventArgs e)
        {
            listView1.View = View.Details;
        }

        private void rdList_CheckedChanged(object sender, EventArgs e)
        {
            listView1.View = View.List;
        }

        private void rdTile_CheckedChanged(object sender, EventArgs e)
        {
            listView1.View = View.Tile;
        }
        private string[] RemebarancesList = { "لا إله إلا الله ", "سبحان الله وبحمده", "أستغفر الله وأتوب إليه", "صلِ على محمد", "لا حول ولا قوة إلا بالله", "سبحان الله العظيم ", "سبحان الله ", "الحمدلله ", "الله أكبر", "ربي اغفر لي ولوالدي" };
        private string[] Sublist = { "كلمة التوحيد ", "خفيفة على اللسان ثقيلة في الميزان", "سبب لغفران الذنوب وزيادة الرزق", "تكفى همك ويغفر ذنبك", "كنز من كنوز الجنة", " حبيبة إلى الرحمن", "الباقيات الصالحات", "الباقيات الصالحات ", "الباقيات الصالحات", "بر واسغفار ودعاء " };

        private void btnFillRandom_Click(object sender, EventArgs e)
        {
            for (byte i = 0; i < RemebarancesList.Length; i++)
            {

                ListViewItem item = new ListViewItem(RemebarancesList[i]);
                if (i < 9)
                    item.ImageIndex = 1;
                else
                    item.ImageIndex = 0;
                item.SubItems.Add(Sublist[i]);
                listView1.Items.Add(item);
            }
        }
    }
}
