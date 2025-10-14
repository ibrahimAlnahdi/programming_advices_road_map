namespace DateTimePicker
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Level 1");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Level 2");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Level3");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Level 4");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("CS", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4});
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("IT");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Colloege of Computers and IT", 1, 3, new System.Windows.Forms.TreeNode[] {
            treeNode5,
            treeNode6});
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button6 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(40, 23);
            this.dateTimePicker1.MinDate = new System.DateTime(2015, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.ShowCheckBox = true;
            this.dateTimePicker1.Size = new System.Drawing.Size(258, 24);
            this.dateTimePicker1.TabIndex = 0;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(40, 89);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(258, 24);
            this.dateTimePicker2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(367, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(40, 151);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 58);
            this.button1.TabIndex = 3;
            this.button1.Text = "Show Short Date";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(214, 151);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(84, 58);
            this.button2.TabIndex = 4;
            this.button2.Text = "Show Long Date";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(40, 221);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 5;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(41, 440);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(83, 47);
            this.button3.TabIndex = 6;
            this.button3.Text = "Start";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(214, 440);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(84, 47);
            this.button4.TabIndex = 7;
            this.button4.Text = "End";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(40, 493);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(258, 33);
            this.button5.TabIndex = 8;
            this.button5.Text = "Selected Range";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(318, 493);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(91, 33);
            this.button6.TabIndex = 9;
            this.button6.Text = "Start Timer";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(334, 421);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 57);
            this.label2.TabIndex = 10;
            this.label2.Text = "0";
            this.label2.Visible = false;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "icons8-person-32.png");
            this.imageList1.Images.SetKeyName(1, "icons8-graduate-50.png");
            this.imageList1.Images.SetKeyName(2, "icons8-learning-50.png");
            this.imageList1.Images.SetKeyName(3, "icons8-security-guard-50.png");
            this.imageList1.Images.SetKeyName(4, "icons8-clean-50.png");
            // 
            // treeView1
            // 
            this.treeView1.CheckBoxes = true;
            this.treeView1.ImageIndex = 0;
            this.treeView1.ImageList = this.imageList1;
            this.treeView1.Location = new System.Drawing.Point(417, 142);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "Node3";
            treeNode1.SelectedImageIndex = 3;
            treeNode1.Text = "Level 1";
            treeNode2.Name = "Node4";
            treeNode2.SelectedImageIndex = 3;
            treeNode2.Text = "Level 2";
            treeNode3.Name = "Node6";
            treeNode3.Text = "Level3";
            treeNode4.Name = "Node7";
            treeNode4.Text = "Level 4";
            treeNode5.Name = "cs";
            treeNode5.Text = "CS";
            treeNode6.ImageIndex = 4;
            treeNode6.Name = "IT";
            treeNode6.Text = "IT";
            treeNode7.Checked = true;
            treeNode7.ImageIndex = 1;
            treeNode7.Name = "Colloege of Computers and IT";
            treeNode7.SelectedImageIndex = 3;
            treeNode7.Text = "Colloege of Computers and IT";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode7});
            this.treeView1.SelectedImageIndex = 0;
            this.treeView1.Size = new System.Drawing.Size(501, 336);
            this.treeView1.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 581);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.TreeView treeView1;
    }
}

