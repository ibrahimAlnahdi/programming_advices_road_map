namespace myFirstWinFormProject
{
    partial class frmMain
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
            this.btnShowForm1 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnShowForm1
            // 
            this.btnShowForm1.AutoEllipsis = true;
            this.btnShowForm1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnShowForm1.FlatAppearance.BorderColor = System.Drawing.Color.Navy;
            this.btnShowForm1.FlatAppearance.BorderSize = 4;
            this.btnShowForm1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.btnShowForm1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowForm1.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowForm1.Location = new System.Drawing.Point(42, 49);
            this.btnShowForm1.Name = "btnShowForm1";
            this.btnShowForm1.Size = new System.Drawing.Size(198, 105);
            this.btnShowForm1.TabIndex = 0;
            this.btnShowForm1.Text = "show form1";
            this.btnShowForm1.UseVisualStyleBackColor = false;
            this.btnShowForm1.Click += new System.EventHandler(this.btnShowForm1_Click);
            // 
            // button1
            // 
            this.button1.AutoEllipsis = true;
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Navy;
            this.button1.FlatAppearance.BorderSize = 4;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(42, 186);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(198, 105);
            this.button1.TabIndex = 1;
            this.button1.Text = "Show message boxs";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnShowForm1);
            this.Name = "frmMain";
            this.Text = "frmMaincs";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnShowForm1;
        private System.Windows.Forms.Button button1;
    }
}