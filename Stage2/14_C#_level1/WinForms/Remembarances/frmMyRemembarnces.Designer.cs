namespace Remembarances
{
    partial class frmMyRemembarnces
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMyRemembarnces));
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtTheker = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdDoa = new System.Windows.Forms.RadioButton();
            this.rdTh = new System.Windows.Forms.RadioButton();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnFillRandom = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdList = new System.Windows.Forms.RadioButton();
            this.rdTile = new System.Windows.Forms.RadioButton();
            this.rdSmallIcon = new System.Windows.Forms.RadioButton();
            this.rdLargeIcone = new System.Windows.Forms.RadioButton();
            this.rdDetails = new System.Windows.Forms.RadioButton();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(556, 38);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(164, 24);
            this.txtID.TabIndex = 0;
            // 
            // txtTheker
            // 
            this.txtTheker.Location = new System.Drawing.Point(556, 87);
            this.txtTheker.Name = "txtTheker";
            this.txtTheker.Size = new System.Drawing.Size(164, 24);
            this.txtTheker.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(726, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 34);
            this.label1.TabIndex = 2;
            this.label1.Text = "الذكر ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(732, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "الفضل";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.rdDoa);
            this.groupBox1.Controls.Add(this.rdTh);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(556, 130);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(241, 76);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "نوع الذكر";
            // 
            // rdDoa
            // 
            this.rdDoa.AutoSize = true;
            this.rdDoa.Location = new System.Drawing.Point(139, 37);
            this.rdDoa.Name = "rdDoa";
            this.rdDoa.Size = new System.Drawing.Size(67, 26);
            this.rdDoa.TabIndex = 1;
            this.rdDoa.TabStop = true;
            this.rdDoa.Text = "دعاء";
            this.rdDoa.UseVisualStyleBackColor = true;
            // 
            // rdTh
            // 
            this.rdTh.AutoSize = true;
            this.rdTh.Location = new System.Drawing.Point(31, 37);
            this.rdTh.Name = "rdTh";
            this.rdTh.Size = new System.Drawing.Size(60, 26);
            this.rdTh.TabIndex = 0;
            this.rdTh.TabStop = true;
            this.rdTh.Text = "ذكر";
            this.rdTh.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(408, 38);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(95, 44);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "إضافة";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.Location = new System.Drawing.Point(408, 88);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(95, 45);
            this.btnRemove.TabIndex = 6;
            this.btnRemove.Text = "حذف";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnFillRandom
            // 
            this.btnFillRandom.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFillRandom.Location = new System.Drawing.Point(408, 139);
            this.btnFillRandom.Name = "btnFillRandom";
            this.btnFillRandom.Size = new System.Drawing.Size(95, 67);
            this.btnFillRandom.TabIndex = 7;
            this.btnFillRandom.Text = "تعبئة تلقائية";
            this.btnFillRandom.UseVisualStyleBackColor = true;
            this.btnFillRandom.Click += new System.EventHandler(this.btnFillRandom_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.rdList);
            this.groupBox2.Controls.Add(this.rdTile);
            this.groupBox2.Controls.Add(this.rdSmallIcon);
            this.groupBox2.Controls.Add(this.rdLargeIcone);
            this.groupBox2.Controls.Add(this.rdDetails);
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(69, 38);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox2.Size = new System.Drawing.Size(326, 168);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "نوع العرض";
            // 
            // rdList
            // 
            this.rdList.AutoSize = true;
            this.rdList.Location = new System.Drawing.Point(45, 89);
            this.rdList.Name = "rdList";
            this.rdList.Size = new System.Drawing.Size(77, 26);
            this.rdList.TabIndex = 4;
            this.rdList.TabStop = true;
            this.rdList.Text = "قائمة";
            this.rdList.UseVisualStyleBackColor = true;
            this.rdList.CheckedChanged += new System.EventHandler(this.rdList_CheckedChanged);
            // 
            // rdTile
            // 
            this.rdTile.AutoSize = true;
            this.rdTile.Location = new System.Drawing.Point(110, 129);
            this.rdTile.Name = "rdTile";
            this.rdTile.Size = new System.Drawing.Size(84, 26);
            this.rdTile.TabIndex = 3;
            this.rdTile.TabStop = true;
            this.rdTile.Text = "لوحات";
            this.rdTile.UseVisualStyleBackColor = true;
            this.rdTile.CheckedChanged += new System.EventHandler(this.rdTile_CheckedChanged);
            // 
            // rdSmallIcon
            // 
            this.rdSmallIcon.AutoSize = true;
            this.rdSmallIcon.Location = new System.Drawing.Point(128, 89);
            this.rdSmallIcon.Name = "rdSmallIcon";
            this.rdSmallIcon.Size = new System.Drawing.Size(151, 26);
            this.rdSmallIcon.TabIndex = 2;
            this.rdSmallIcon.TabStop = true;
            this.rdSmallIcon.Text = "ايقونات صغيرة";
            this.rdSmallIcon.UseVisualStyleBackColor = true;
            this.rdSmallIcon.CheckedChanged += new System.EventHandler(this.rdSmallIcon_CheckedChanged);
            // 
            // rdLargeIcone
            // 
            this.rdLargeIcone.AutoSize = true;
            this.rdLargeIcone.Location = new System.Drawing.Point(139, 37);
            this.rdLargeIcone.Name = "rdLargeIcone";
            this.rdLargeIcone.Size = new System.Drawing.Size(140, 26);
            this.rdLargeIcone.TabIndex = 1;
            this.rdLargeIcone.TabStop = true;
            this.rdLargeIcone.Text = "ايقونات كبيرة";
            this.rdLargeIcone.UseVisualStyleBackColor = true;
            this.rdLargeIcone.CheckedChanged += new System.EventHandler(this.rdLargeIcone_CheckedChanged);
            // 
            // rdDetails
            // 
            this.rdDetails.AutoSize = true;
            this.rdDetails.Location = new System.Drawing.Point(31, 37);
            this.rdDetails.Name = "rdDetails";
            this.rdDetails.Size = new System.Drawing.Size(92, 26);
            this.rdDetails.TabIndex = 0;
            this.rdDetails.TabStop = true;
            this.rdDetails.Text = "تفاصيل";
            this.rdDetails.UseVisualStyleBackColor = true;
            this.rdDetails.CheckedChanged += new System.EventHandler(this.rdDetails_CheckedChanged);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listView1.HideSelection = false;
            this.listView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.listView1.LargeImageList = this.imageList2;
            this.listView1.Location = new System.Drawing.Point(53, 227);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(730, 253);
            this.listView1.SmallImageList = this.imageList1;
            this.listView1.TabIndex = 9;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "الذكر";
            this.columnHeader1.Width = 174;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "الفضل";
            // 
            // imageList2
            // 
            this.imageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList2.ImageStream")));
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList2.Images.SetKeyName(0, "Doa.png");
            this.imageList2.Images.SetKeyName(1, "thekr.png");
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Doa.png");
            this.imageList1.Images.SetKeyName(1, "thekr.png");
            // 
            // frmMyRemembarnces
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 611);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnFillRandom);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTheker);
            this.Controls.Add(this.txtID);
            this.Name = "frmMyRemembarnces";
            this.Text = "frmMyRemembarnces";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtTheker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdDoa;
        private System.Windows.Forms.RadioButton rdTh;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnFillRandom;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdList;
        private System.Windows.Forms.RadioButton rdTile;
        private System.Windows.Forms.RadioButton rdSmallIcon;
        private System.Windows.Forms.RadioButton rdLargeIcone;
        private System.Windows.Forms.RadioButton rdDetails;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ImageList imageList2;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
    }
}