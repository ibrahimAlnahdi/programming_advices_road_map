namespace pizzaProject
{
    partial class frmOrderPizza
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOrderPizza));
            this.gpPizzaSize = new System.Windows.Forms.GroupBox();
            this.rdLarg = new System.Windows.Forms.RadioButton();
            this.rdMduim = new System.Windows.Forms.RadioButton();
            this.rdSmall = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.lbTitle = new System.Windows.Forms.Label();
            this.gpCrustType = new System.Windows.Forms.GroupBox();
            this.rdThinkCrust = new System.Windows.Forms.RadioButton();
            this.rdThinCrust = new System.Windows.Forms.RadioButton();
            this.gpToppings = new System.Windows.Forms.GroupBox();
            this.chkOlives = new System.Windows.Forms.CheckBox();
            this.chkOnion = new System.Windows.Forms.CheckBox();
            this.chkTomatoes = new System.Windows.Forms.CheckBox();
            this.chkGreenPeppers = new System.Windows.Forms.CheckBox();
            this.chkMushroom = new System.Windows.Forms.CheckBox();
            this.chkExtraCheese = new System.Windows.Forms.CheckBox();
            this.gpWhereToEat = new System.Windows.Forms.GroupBox();
            this.rdTakeOut = new System.Windows.Forms.RadioButton();
            this.rdEatIn = new System.Windows.Forms.RadioButton();
            this.gpSummary = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbToppings = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbWhereToEat = new System.Windows.Forms.Label();
            this.lbCrustType = new System.Windows.Forms.Label();
            this.lbSize = new System.Windows.Forms.Label();
            this.btnOrderPizza = new System.Windows.Forms.Button();
            this.btnRestForm = new System.Windows.Forms.Button();
            this.gpPrice = new System.Windows.Forms.GroupBox();
            this.lbPrice = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblTimer = new System.Windows.Forms.Label();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.gpPizzaSize.SuspendLayout();
            this.gpCrustType.SuspendLayout();
            this.gpToppings.SuspendLayout();
            this.gpWhereToEat.SuspendLayout();
            this.gpSummary.SuspendLayout();
            this.gpPrice.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpPizzaSize
            // 
            this.gpPizzaSize.BackColor = System.Drawing.Color.Transparent;
            this.gpPizzaSize.Controls.Add(this.rdLarg);
            this.gpPizzaSize.Controls.Add(this.rdMduim);
            this.gpPizzaSize.Controls.Add(this.rdSmall);
            this.gpPizzaSize.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpPizzaSize.ForeColor = System.Drawing.Color.SandyBrown;
            this.gpPizzaSize.Location = new System.Drawing.Point(35, 37);
            this.gpPizzaSize.Name = "gpPizzaSize";
            this.gpPizzaSize.Size = new System.Drawing.Size(161, 171);
            this.gpPizzaSize.TabIndex = 0;
            this.gpPizzaSize.TabStop = false;
            this.gpPizzaSize.Text = "Pizza Size";
            // 
            // rdLarg
            // 
            this.rdLarg.AutoSize = true;
            this.rdLarg.Location = new System.Drawing.Point(26, 118);
            this.rdLarg.Name = "rdLarg";
            this.rdLarg.Size = new System.Drawing.Size(76, 28);
            this.rdLarg.TabIndex = 2;
            this.rdLarg.TabStop = true;
            this.rdLarg.Tag = "4000";
            this.rdLarg.Text = "Larg";
            this.rdLarg.UseVisualStyleBackColor = true;
            this.rdLarg.CheckedChanged += new System.EventHandler(this.rdLarg_CheckedChanged);
            // 
            // rdMduim
            // 
            this.rdMduim.AutoSize = true;
            this.rdMduim.Location = new System.Drawing.Point(26, 75);
            this.rdMduim.Name = "rdMduim";
            this.rdMduim.Size = new System.Drawing.Size(112, 28);
            this.rdMduim.TabIndex = 1;
            this.rdMduim.TabStop = true;
            this.rdMduim.Tag = "3000";
            this.rdMduim.Text = "Meduim";
            this.rdMduim.UseVisualStyleBackColor = true;
            this.rdMduim.CheckedChanged += new System.EventHandler(this.rdMduim_CheckedChanged);
            // 
            // rdSmall
            // 
            this.rdSmall.AutoSize = true;
            this.rdSmall.Location = new System.Drawing.Point(26, 38);
            this.rdSmall.Name = "rdSmall";
            this.rdSmall.Size = new System.Drawing.Size(87, 28);
            this.rdSmall.TabIndex = 0;
            this.rdSmall.TabStop = true;
            this.rdSmall.Tag = "2000";
            this.rdSmall.Text = "Small";
            this.rdSmall.UseVisualStyleBackColor = true;
            this.rdSmall.CheckedChanged += new System.EventHandler(this.rdSmall_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MV Boli", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(236, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 44);
            this.label1.TabIndex = 1;
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.BackColor = System.Drawing.Color.Transparent;
            this.lbTitle.Font = new System.Drawing.Font("Segoe Script", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.ForeColor = System.Drawing.Color.Red;
            this.lbTitle.Location = new System.Drawing.Point(314, 1);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(392, 67);
            this.lbTitle.TabIndex = 3;
            this.lbTitle.Text = "Make Your Pizza";
            // 
            // gpCrustType
            // 
            this.gpCrustType.BackColor = System.Drawing.Color.Transparent;
            this.gpCrustType.Controls.Add(this.rdThinkCrust);
            this.gpCrustType.Controls.Add(this.rdThinCrust);
            this.gpCrustType.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpCrustType.ForeColor = System.Drawing.Color.SandyBrown;
            this.gpCrustType.Location = new System.Drawing.Point(35, 223);
            this.gpCrustType.Name = "gpCrustType";
            this.gpCrustType.Size = new System.Drawing.Size(161, 115);
            this.gpCrustType.TabIndex = 4;
            this.gpCrustType.TabStop = false;
            this.gpCrustType.Text = "Crust Type";
            // 
            // rdThinkCrust
            // 
            this.rdThinkCrust.AutoSize = true;
            this.rdThinkCrust.Location = new System.Drawing.Point(26, 66);
            this.rdThinkCrust.Name = "rdThinkCrust";
            this.rdThinkCrust.Size = new System.Drawing.Size(146, 28);
            this.rdThinkCrust.TabIndex = 1;
            this.rdThinkCrust.TabStop = true;
            this.rdThinkCrust.Tag = "1000";
            this.rdThinkCrust.Text = "Think Crust";
            this.rdThinkCrust.UseVisualStyleBackColor = true;
            this.rdThinkCrust.CheckedChanged += new System.EventHandler(this.rdThinkCrust_CheckedChanged);
            // 
            // rdThinCrust
            // 
            this.rdThinCrust.AutoSize = true;
            this.rdThinCrust.Location = new System.Drawing.Point(26, 32);
            this.rdThinCrust.Name = "rdThinCrust";
            this.rdThinCrust.Size = new System.Drawing.Size(134, 28);
            this.rdThinCrust.TabIndex = 0;
            this.rdThinCrust.TabStop = true;
            this.rdThinCrust.Text = "Thin Crust";
            this.rdThinCrust.UseVisualStyleBackColor = true;
            this.rdThinCrust.CheckedChanged += new System.EventHandler(this.rdThinCrust_CheckedChanged);
            // 
            // gpToppings
            // 
            this.gpToppings.BackColor = System.Drawing.Color.Transparent;
            this.gpToppings.Controls.Add(this.chkOlives);
            this.gpToppings.Controls.Add(this.chkOnion);
            this.gpToppings.Controls.Add(this.chkTomatoes);
            this.gpToppings.Controls.Add(this.chkGreenPeppers);
            this.gpToppings.Controls.Add(this.chkMushroom);
            this.gpToppings.Controls.Add(this.chkExtraCheese);
            this.gpToppings.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpToppings.ForeColor = System.Drawing.Color.SandyBrown;
            this.gpToppings.Location = new System.Drawing.Point(652, 50);
            this.gpToppings.Name = "gpToppings";
            this.gpToppings.Size = new System.Drawing.Size(314, 158);
            this.gpToppings.TabIndex = 5;
            this.gpToppings.TabStop = false;
            this.gpToppings.Text = "Toppings";
            // 
            // chkOlives
            // 
            this.chkOlives.AutoSize = true;
            this.chkOlives.Location = new System.Drawing.Point(185, 113);
            this.chkOlives.Name = "chkOlives";
            this.chkOlives.Size = new System.Drawing.Size(93, 28);
            this.chkOlives.TabIndex = 5;
            this.chkOlives.Tag = "1000";
            this.chkOlives.Text = "Olives";
            this.chkOlives.UseVisualStyleBackColor = true;
            this.chkOlives.CheckedChanged += new System.EventHandler(this.chkOlives_CheckedChanged);
            // 
            // chkOnion
            // 
            this.chkOnion.AutoSize = true;
            this.chkOnion.Location = new System.Drawing.Point(185, 70);
            this.chkOnion.Name = "chkOnion";
            this.chkOnion.Size = new System.Drawing.Size(91, 28);
            this.chkOnion.TabIndex = 4;
            this.chkOnion.Tag = "500";
            this.chkOnion.Text = "Onion";
            this.chkOnion.UseVisualStyleBackColor = true;
            this.chkOnion.CheckedChanged += new System.EventHandler(this.chkOnion_CheckedChanged);
            // 
            // chkTomatoes
            // 
            this.chkTomatoes.AutoSize = true;
            this.chkTomatoes.Location = new System.Drawing.Point(185, 31);
            this.chkTomatoes.Name = "chkTomatoes";
            this.chkTomatoes.Size = new System.Drawing.Size(129, 28);
            this.chkTomatoes.TabIndex = 3;
            this.chkTomatoes.Tag = "500";
            this.chkTomatoes.Text = "Tomatoes";
            this.chkTomatoes.UseVisualStyleBackColor = true;
            this.chkTomatoes.CheckedChanged += new System.EventHandler(this.chkTomatoes_CheckedChanged);
            // 
            // chkGreenPeppers
            // 
            this.chkGreenPeppers.AutoSize = true;
            this.chkGreenPeppers.Location = new System.Drawing.Point(6, 113);
            this.chkGreenPeppers.Name = "chkGreenPeppers";
            this.chkGreenPeppers.Size = new System.Drawing.Size(181, 28);
            this.chkGreenPeppers.TabIndex = 2;
            this.chkGreenPeppers.Tag = "500";
            this.chkGreenPeppers.Text = "Green Peppers";
            this.chkGreenPeppers.UseVisualStyleBackColor = true;
            this.chkGreenPeppers.CheckedChanged += new System.EventHandler(this.chkGreenPeppers_CheckedChanged);
            // 
            // chkMushroom
            // 
            this.chkMushroom.AutoSize = true;
            this.chkMushroom.Location = new System.Drawing.Point(6, 70);
            this.chkMushroom.Name = "chkMushroom";
            this.chkMushroom.Size = new System.Drawing.Size(148, 28);
            this.chkMushroom.TabIndex = 1;
            this.chkMushroom.Tag = "1500";
            this.chkMushroom.Text = "Mushrooms";
            this.chkMushroom.UseVisualStyleBackColor = true;
            this.chkMushroom.CheckedChanged += new System.EventHandler(this.chkMushroom_CheckedChanged);
            // 
            // chkExtraCheese
            // 
            this.chkExtraCheese.AutoSize = true;
            this.chkExtraCheese.Location = new System.Drawing.Point(6, 31);
            this.chkExtraCheese.Name = "chkExtraCheese";
            this.chkExtraCheese.Size = new System.Drawing.Size(163, 28);
            this.chkExtraCheese.TabIndex = 0;
            this.chkExtraCheese.Tag = "1000";
            this.chkExtraCheese.Text = "Extra Cheese";
            this.chkExtraCheese.UseVisualStyleBackColor = true;
            this.chkExtraCheese.CheckedChanged += new System.EventHandler(this.chkExtraCheese_CheckedChanged);
            // 
            // gpWhereToEat
            // 
            this.gpWhereToEat.BackColor = System.Drawing.Color.Transparent;
            this.gpWhereToEat.Controls.Add(this.rdTakeOut);
            this.gpWhereToEat.Controls.Add(this.rdEatIn);
            this.gpWhereToEat.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpWhereToEat.ForeColor = System.Drawing.Color.SandyBrown;
            this.gpWhereToEat.Location = new System.Drawing.Point(35, 375);
            this.gpWhereToEat.Name = "gpWhereToEat";
            this.gpWhereToEat.Size = new System.Drawing.Size(160, 100);
            this.gpWhereToEat.TabIndex = 6;
            this.gpWhereToEat.TabStop = false;
            this.gpWhereToEat.Text = "Where To Eat";
            // 
            // rdTakeOut
            // 
            this.rdTakeOut.AutoSize = true;
            this.rdTakeOut.Location = new System.Drawing.Point(26, 66);
            this.rdTakeOut.Name = "rdTakeOut";
            this.rdTakeOut.Size = new System.Drawing.Size(121, 28);
            this.rdTakeOut.TabIndex = 1;
            this.rdTakeOut.TabStop = true;
            this.rdTakeOut.Text = "Take Out";
            this.rdTakeOut.UseVisualStyleBackColor = true;
            this.rdTakeOut.CheckedChanged += new System.EventHandler(this.rdTakeOut_CheckedChanged);
            // 
            // rdEatIn
            // 
            this.rdEatIn.AutoSize = true;
            this.rdEatIn.Location = new System.Drawing.Point(26, 32);
            this.rdEatIn.Name = "rdEatIn";
            this.rdEatIn.Size = new System.Drawing.Size(92, 28);
            this.rdEatIn.TabIndex = 0;
            this.rdEatIn.TabStop = true;
            this.rdEatIn.Text = "Eat In";
            this.rdEatIn.UseVisualStyleBackColor = true;
            this.rdEatIn.CheckedChanged += new System.EventHandler(this.rdEatIn_CheckedChanged);
            // 
            // gpSummary
            // 
            this.gpSummary.BackColor = System.Drawing.Color.Transparent;
            this.gpSummary.Controls.Add(this.label2);
            this.gpSummary.Controls.Add(this.lbToppings);
            this.gpSummary.Controls.Add(this.label6);
            this.gpSummary.Controls.Add(this.label4);
            this.gpSummary.Controls.Add(this.label3);
            this.gpSummary.Controls.Add(this.lbWhereToEat);
            this.gpSummary.Controls.Add(this.lbCrustType);
            this.gpSummary.Controls.Add(this.lbSize);
            this.gpSummary.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpSummary.ForeColor = System.Drawing.Color.SandyBrown;
            this.gpSummary.Location = new System.Drawing.Point(652, 214);
            this.gpSummary.Name = "gpSummary";
            this.gpSummary.Size = new System.Drawing.Size(314, 270);
            this.gpSummary.TabIndex = 7;
            this.gpSummary.TabStop = false;
            this.gpSummary.Text = "Order Summary";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(100, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 24);
            this.label2.TabIndex = 14;
            this.label2.Text = "Toppings : ";
            // 
            // lbToppings
            // 
            this.lbToppings.AllowDrop = true;
            this.lbToppings.AutoEllipsis = true;
            this.lbToppings.Location = new System.Drawing.Point(84, 169);
            this.lbToppings.Name = "lbToppings";
            this.lbToppings.Size = new System.Drawing.Size(232, 98);
            this.lbToppings.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(111, 105);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 24);
            this.label6.TabIndex = 11;
            this.label6.Text = "Size : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 24);
            this.label4.TabIndex = 12;
            this.label4.Text = "Crust Type : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 24);
            this.label3.TabIndex = 13;
            this.label3.Text = "Where To Eat : ";
            // 
            // lbWhereToEat
            // 
            this.lbWhereToEat.AutoSize = true;
            this.lbWhereToEat.Location = new System.Drawing.Point(192, 33);
            this.lbWhereToEat.Name = "lbWhereToEat";
            this.lbWhereToEat.Size = new System.Drawing.Size(0, 24);
            this.lbWhereToEat.TabIndex = 2;
            // 
            // lbCrustType
            // 
            this.lbCrustType.AutoSize = true;
            this.lbCrustType.Location = new System.Drawing.Point(167, 70);
            this.lbCrustType.Name = "lbCrustType";
            this.lbCrustType.Size = new System.Drawing.Size(0, 24);
            this.lbCrustType.TabIndex = 1;
            // 
            // lbSize
            // 
            this.lbSize.AutoSize = true;
            this.lbSize.Location = new System.Drawing.Point(192, 105);
            this.lbSize.Name = "lbSize";
            this.lbSize.Size = new System.Drawing.Size(0, 24);
            this.lbSize.TabIndex = 0;
            // 
            // btnOrderPizza
            // 
            this.btnOrderPizza.BackColor = System.Drawing.Color.Black;
            this.btnOrderPizza.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrderPizza.Location = new System.Drawing.Point(244, 551);
            this.btnOrderPizza.Name = "btnOrderPizza";
            this.btnOrderPizza.Size = new System.Drawing.Size(137, 59);
            this.btnOrderPizza.TabIndex = 8;
            this.btnOrderPizza.Text = "Order Pizza";
            this.btnOrderPizza.UseVisualStyleBackColor = false;
            this.btnOrderPizza.Click += new System.EventHandler(this.btnOrderPizza_Click);
            // 
            // btnRestForm
            // 
            this.btnRestForm.BackColor = System.Drawing.Color.Black;
            this.btnRestForm.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestForm.Location = new System.Drawing.Point(494, 551);
            this.btnRestForm.Name = "btnRestForm";
            this.btnRestForm.Size = new System.Drawing.Size(137, 59);
            this.btnRestForm.TabIndex = 9;
            this.btnRestForm.Text = "Reset Form";
            this.btnRestForm.UseVisualStyleBackColor = false;
            this.btnRestForm.Click += new System.EventHandler(this.btnRestForm_Click);
            // 
            // gpPrice
            // 
            this.gpPrice.BackColor = System.Drawing.Color.Transparent;
            this.gpPrice.Controls.Add(this.lbPrice);
            this.gpPrice.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpPrice.ForeColor = System.Drawing.Color.LawnGreen;
            this.gpPrice.Location = new System.Drawing.Point(656, 510);
            this.gpPrice.Name = "gpPrice";
            this.gpPrice.Size = new System.Drawing.Size(310, 100);
            this.gpPrice.TabIndex = 10;
            this.gpPrice.TabStop = false;
            this.gpPrice.Text = "Total Price";
            // 
            // lbPrice
            // 
            this.lbPrice.AutoSize = true;
            this.lbPrice.Font = new System.Drawing.Font("Tahoma", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPrice.Location = new System.Drawing.Point(44, 45);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(191, 45);
            this.lbPrice.TabIndex = 0;
            this.lbPrice.Text = "2000 R.Y";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.BackColor = System.Drawing.Color.Transparent;
            this.lblTimer.Font = new System.Drawing.Font("Tahoma", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimer.ForeColor = System.Drawing.Color.LawnGreen;
            this.lblTimer.Location = new System.Drawing.Point(51, 541);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(55, 57);
            this.lblTimer.TabIndex = 11;
            this.lblTimer.Text = "0";
            this.lblTimer.Visible = false;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon1.BalloonTipText = "Preparing Your Pizza";
            this.notifyIcon1.BalloonTipTitle = "Waitting";
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // frmOrderPizza
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(980, 639);
            this.Controls.Add(this.lblTimer);
            this.Controls.Add(this.gpPrice);
            this.Controls.Add(this.btnRestForm);
            this.Controls.Add(this.btnOrderPizza);
            this.Controls.Add(this.gpSummary);
            this.Controls.Add(this.gpWhereToEat);
            this.Controls.Add(this.gpToppings);
            this.Controls.Add(this.gpCrustType);
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gpPizzaSize);
            this.ForeColor = System.Drawing.Color.SandyBrown;
            this.Name = "frmOrderPizza";
            this.Text = "frmOrderPizza";
            this.Load += new System.EventHandler(this.frmOrderPizza_Load);
            this.gpPizzaSize.ResumeLayout(false);
            this.gpPizzaSize.PerformLayout();
            this.gpCrustType.ResumeLayout(false);
            this.gpCrustType.PerformLayout();
            this.gpToppings.ResumeLayout(false);
            this.gpToppings.PerformLayout();
            this.gpWhereToEat.ResumeLayout(false);
            this.gpWhereToEat.PerformLayout();
            this.gpSummary.ResumeLayout(false);
            this.gpSummary.PerformLayout();
            this.gpPrice.ResumeLayout(false);
            this.gpPrice.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gpPizzaSize;
        private System.Windows.Forms.RadioButton rdLarg;
        private System.Windows.Forms.RadioButton rdMduim;
        private System.Windows.Forms.RadioButton rdSmall;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.GroupBox gpCrustType;
        private System.Windows.Forms.RadioButton rdThinkCrust;
        private System.Windows.Forms.RadioButton rdThinCrust;
        private System.Windows.Forms.GroupBox gpToppings;
        private System.Windows.Forms.CheckBox chkOlives;
        private System.Windows.Forms.CheckBox chkOnion;
        private System.Windows.Forms.CheckBox chkTomatoes;
        private System.Windows.Forms.CheckBox chkGreenPeppers;
        private System.Windows.Forms.CheckBox chkMushroom;
        private System.Windows.Forms.CheckBox chkExtraCheese;
        private System.Windows.Forms.GroupBox gpWhereToEat;
        private System.Windows.Forms.RadioButton rdTakeOut;
        private System.Windows.Forms.RadioButton rdEatIn;
        private System.Windows.Forms.GroupBox gpSummary;
        private System.Windows.Forms.Button btnOrderPizza;
        private System.Windows.Forms.Button btnRestForm;
        private System.Windows.Forms.GroupBox gpPrice;
        private System.Windows.Forms.Label lbPrice;
        private System.Windows.Forms.Label lbToppings;
        private System.Windows.Forms.Label lbWhereToEat;
        private System.Windows.Forms.Label lbCrustType;
        private System.Windows.Forms.Label lbSize;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
    }
}