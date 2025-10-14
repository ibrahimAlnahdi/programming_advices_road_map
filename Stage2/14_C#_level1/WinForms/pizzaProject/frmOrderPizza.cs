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
    public partial class frmOrderPizza : Form
    {

        public frmOrderPizza()
        {
            InitializeComponent();
        }
        private float GetSelectedSizePrice()
        {
            if (rdSmall.Checked)

                return Convert.ToSingle(rdSmall.Tag);
            else if (rdMduim.Checked)
                return Convert.ToSingle(rdMduim.Tag);
            else
                return Convert.ToSingle(rdLarg.Tag);

        }
        float CalculateToppingsPrice()
        {
            float price = 0;
            if (chkExtraCheese.Checked)
                price += Convert.ToSingle(chkExtraCheese.Tag);
            if (chkMushroom.Checked)
                price += Convert.ToSingle(chkMushroom.Tag);
            if (chkGreenPeppers.Checked)
                price += Convert.ToSingle(chkGreenPeppers.Tag);
            if (chkTomatoes.Checked)
                price += Convert.ToSingle(chkTomatoes.Tag);
            if (chkOnion.Checked)
                price += Convert.ToSingle(chkOnion.Tag);
            if (chkOlives.Checked)
                price += Convert.ToSingle(chkOlives.Tag);

            return price;

        }
        float CalculateCrustTypePrice()
        {
            if (rdThinkCrust.Checked)
            {
                return Convert.ToSingle(rdThinkCrust.Tag);
            }
            return 0;
        }
        float CalculateTotalPrice()
        {
            return GetSelectedSizePrice() + CalculateToppingsPrice() 
                + CalculateCrustTypePrice(); 
        }
        void UpdatePrice()
        {
            lbPrice.Text = CalculateTotalPrice().ToString()+" R.Y";
        }
        string GetPizzaSize()
        {
            if (rdSmall.Checked)
                return rdSmall.Text;
            else if (rdMduim.Checked)
                return rdMduim.Text;
            else 
                return rdLarg.Text;
        }
        string GetCrustType()
        {
            return rdThinkCrust.Checked ? rdThinkCrust.Text : rdThinCrust.Text;
        }
         string GetWhereToEat()
        {
            return rdTakeOut.Checked ? rdTakeOut.Text : rdEatIn.Text;
        }
        string GetToppings()
        {
            string Toppings = "";
            if (chkExtraCheese.Checked)
                Toppings += (chkExtraCheese.Text);
            if (chkOnion.Checked)
                Toppings += (", " + chkOnion.Text);
            if (chkMushroom.Checked)
                Toppings += (", " + chkMushroom.Text);
            if (chkTomatoes.Checked)
                Toppings += (", " + chkTomatoes.Text);
            if (chkGreenPeppers.Checked)
                Toppings += (", " + chkGreenPeppers.Text);
             if (chkOlives.Checked)
                Toppings += (", "+chkOlives.Text);
            if (Toppings.StartsWith(","))
            {
                Toppings = Toppings.Substring(1, Toppings.Length - 1).Trim();
            }
            if (Toppings == "")
                Toppings = "No Toppings";
            return Toppings;
        }

        void UpdateOrderSummary()
        {
            lbWhereToEat.Text = GetWhereToEat();
            lbCrustType.Text = GetCrustType();
            lbSize.Text = GetPizzaSize();
            lbToppings.Text = GetToppings();
        }
        private void rdSmall_CheckedChanged(object sender, EventArgs e)
        {
            UpdatePrice();
            UpdateOrderSummary();
        }

        private void rdMduim_CheckedChanged(object sender, EventArgs e)
        {
            UpdatePrice();
            UpdateOrderSummary();

        }

        private void rdLarg_CheckedChanged(object sender, EventArgs e)
        {
            UpdatePrice();
            UpdateOrderSummary();

        }

        private void frmOrderPizza_Load(object sender, EventArgs e)
        {
           

        }

        private void rdThinkCrust_CheckedChanged(object sender, EventArgs e)
        {
            UpdatePrice();
            UpdateOrderSummary();

        }

        private void chkExtraCheese_CheckedChanged(object sender, EventArgs e)
        {
            UpdatePrice();
            UpdateOrderSummary();

        }

        private void chkTomatoes_CheckedChanged(object sender, EventArgs e)
        {
            UpdatePrice();
            UpdateOrderSummary();

        }

        private void chkMushroom_CheckedChanged(object sender, EventArgs e)
        {
            UpdatePrice();
            UpdateOrderSummary();

        }

        private void chkGreenPeppers_CheckedChanged(object sender, EventArgs e)
        {
            UpdatePrice();
            UpdateOrderSummary();

        }

        private void chkOnion_CheckedChanged(object sender, EventArgs e)
        {
            UpdatePrice();
            UpdateOrderSummary();

        }

        private void chkOlives_CheckedChanged(object sender, EventArgs e)
        {
            UpdatePrice();
            UpdateOrderSummary();

        }

        private void rdThinCrust_CheckedChanged(object sender, EventArgs e)
        {
            UpdatePrice();
            UpdateOrderSummary();

        }

        private void rdEatIn_CheckedChanged(object sender, EventArgs e)
        {
            UpdatePrice();
            UpdateOrderSummary();

        }

        private void rdTakeOut_CheckedChanged(object sender, EventArgs e)
        {
            UpdatePrice();
            UpdateOrderSummary();

        }

        private void btnOrderPizza_Click(object sender, EventArgs e)
        {
            gpPizzaSize.Enabled = false;
            gpToppings.Enabled = false;
            gpCrustType.Enabled = false;
            gpWhereToEat.Enabled = false;
            timer1.Enabled = true;
            lblTimer.Visible = true;
            notifyIcon1.Icon = SystemIcons.Application;

            notifyIcon1.ShowBalloonTip(1000);
        }

        private void btnRestForm_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            this.InitializeComponent();
            Counter = 0;
        }
        private int Counter = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            Counter++;
            lblTimer.Text = Counter.ToString();

        }
    }
}
