using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TreeView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
        }

        private void treeView1_DoubleClick(object sender, EventArgs e)
        {
            MessageBox.Show(treeView1.SelectedNode.Text);

        }

        void CheckedAllNodes(TreeNode node, bool isChecked)
        {
            foreach (TreeNode item in node.Nodes)
            {
                item.Checked = isChecked;
                if(item.Nodes.Count < 0)
                {
                    CheckedAllNodes(item, isChecked);
                }
            }    
           
        }
        private void treeView1_AfterCheck(object sender, TreeViewEventArgs e)
        {
            CheckedAllNodes(e.Node, e.Node.Checked);
        }
    }
}
