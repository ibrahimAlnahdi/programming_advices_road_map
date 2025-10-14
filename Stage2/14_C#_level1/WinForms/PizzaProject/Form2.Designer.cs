namespace pizzaProject
{
    partial class Form2
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
            this.btnPorgar = new System.Windows.Forms.RadioButton();
            this.btnShaorma = new System.Windows.Forms.RadioButton();
            this.rdFrise = new System.Windows.Forms.RadioButton();
            this.rdFlafel = new System.Windows.Forms.RadioButton();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPorgar
            // 
            this.btnPorgar.AutoSize = true;
            this.btnPorgar.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPorgar.ForeColor = System.Drawing.Color.SandyBrown;
            this.btnPorgar.Location = new System.Drawing.Point(185, 420);
            this.btnPorgar.Name = "btnPorgar";
            this.btnPorgar.Size = new System.Drawing.Size(100, 28);
            this.btnPorgar.TabIndex = 1;
            this.btnPorgar.TabStop = true;
            this.btnPorgar.Text = "Purgar";
            this.btnPorgar.UseVisualStyleBackColor = true;
            this.btnPorgar.CheckedChanged += new System.EventHandler(this.btnPorgar_CheckedChanged);
            // 
            // btnShaorma
            // 
            this.btnShaorma.AutoSize = true;
            this.btnShaorma.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShaorma.ForeColor = System.Drawing.Color.SandyBrown;
            this.btnShaorma.Location = new System.Drawing.Point(185, 462);
            this.btnShaorma.Name = "btnShaorma";
            this.btnShaorma.Size = new System.Drawing.Size(139, 28);
            this.btnShaorma.TabIndex = 2;
            this.btnShaorma.TabStop = true;
            this.btnShaorma.Text = "Shawarma";
            this.btnShaorma.UseVisualStyleBackColor = true;
            this.btnShaorma.CheckedChanged += new System.EventHandler(this.btnShaorma_CheckedChanged);
            // 
            // rdFrise
            // 
            this.rdFrise.AutoSize = true;
            this.rdFrise.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdFrise.ForeColor = System.Drawing.Color.SandyBrown;
            this.rdFrise.Location = new System.Drawing.Point(410, 462);
            this.rdFrise.Name = "rdFrise";
            this.rdFrise.Size = new System.Drawing.Size(80, 28);
            this.rdFrise.TabIndex = 4;
            this.rdFrise.TabStop = true;
            this.rdFrise.Text = "Fries";
            this.rdFrise.UseVisualStyleBackColor = true;
            this.rdFrise.CheckedChanged += new System.EventHandler(this.rdFrise_CheckedChanged);
            // 
            // rdFlafel
            // 
            this.rdFlafel.AutoSize = true;
            this.rdFlafel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdFlafel.ForeColor = System.Drawing.Color.SandyBrown;
            this.rdFlafel.Location = new System.Drawing.Point(410, 420);
            this.rdFlafel.Name = "rdFlafel";
            this.rdFlafel.Size = new System.Drawing.Size(99, 28);
            this.rdFlafel.TabIndex = 3;
            this.rdFlafel.TabStop = true;
            this.rdFlafel.Text = "Falafel";
            this.rdFlafel.UseVisualStyleBackColor = true;
            this.rdFlafel.CheckedChanged += new System.EventHandler(this.rdFlafel_CheckedChanged);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Comic Sans MS", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Red;
            this.lblTitle.Location = new System.Drawing.Point(271, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(177, 45);
            this.lblTitle.TabIndex = 5;
            this.lblTitle.Text = "Fast Food";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::pizzaProject.Properties.Resources.fastFood2;
            this.pictureBox1.Location = new System.Drawing.Point(185, 45);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(357, 369);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Falafel",
            "Fries",
            "Purgar",
            "Shawarma"});
            this.comboBox1.Location = new System.Drawing.Point(279, 57);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(169, 24);
            this.comboBox1.Sorted = true;
            this.comboBox1.TabIndex = 6;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(723, 499);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.rdFrise);
            this.Controls.Add(this.rdFlafel);
            this.Controls.Add(this.btnShaorma);
            this.Controls.Add(this.btnPorgar);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form2";
            this.Text = "Products";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RadioButton btnPorgar;
        private System.Windows.Forms.RadioButton btnShaorma;
        private System.Windows.Forms.RadioButton rdFrise;
        private System.Windows.Forms.RadioButton rdFlafel;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}