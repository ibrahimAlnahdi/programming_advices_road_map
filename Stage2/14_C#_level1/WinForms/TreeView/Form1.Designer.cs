namespace TreeView
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Ahmed");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Ali");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Boys", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2});
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Huda", 1, 2);
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Alia", 1, 2);
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Girls", 1, 2, new System.Windows.Forms.TreeNode[] {
            treeNode4,
            treeNode5});
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "student-with-graduation-cap.png");
            this.imageList1.Images.SetKeyName(1, "icons8-person-32.png");
            this.imageList1.Images.SetKeyName(2, "icons8-stratching-30.png");
            this.imageList1.Images.SetKeyName(3, "student-with-graduation-cap.png");
            // 
            // treeView1
            // 
            this.treeView1.CheckBoxes = true;
            this.treeView1.ImageIndex = 0;
            this.treeView1.ImageList = this.imageList1;
            this.treeView1.Location = new System.Drawing.Point(98, 12);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "Node2";
            treeNode1.SelectedImageIndex = 2;
            treeNode1.Text = "Ahmed";
            treeNode2.Name = "Node3";
            treeNode2.SelectedImageIndex = 2;
            treeNode2.Text = "Ali";
            treeNode3.Name = "Node0";
            treeNode3.SelectedImageIndex = 2;
            treeNode3.Text = "Boys";
            treeNode4.ImageIndex = 1;
            treeNode4.Name = "Node4";
            treeNode4.SelectedImageIndex = 2;
            treeNode4.Text = "Huda";
            treeNode5.ImageIndex = 1;
            treeNode5.Name = "Node5";
            treeNode5.SelectedImageIndex = 2;
            treeNode5.Text = "Alia";
            treeNode6.Checked = true;
            treeNode6.ImageIndex = 1;
            treeNode6.Name = "Node1";
            treeNode6.SelectedImageIndex = 2;
            treeNode6.Text = "Girls";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode3,
            treeNode6});
            this.treeView1.SelectedImageIndex = 0;
            this.treeView1.Size = new System.Drawing.Size(372, 426);
            this.treeView1.TabIndex = 0;
            this.treeView1.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterCheck);
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            this.treeView1.DoubleClick += new System.EventHandler(this.treeView1_DoubleClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 515);
            this.Controls.Add(this.treeView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.TreeView treeView1;
    }
}

