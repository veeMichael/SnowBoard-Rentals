using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Snowboard_Rentals
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        const int nBoots = 20;
        const int yBoots = 30;
        int drsBoots = 0;
        int drsnBoots = 0;
        int drsTotal = 0;
        int orders = 1;

        
        
        private void btnCalcOrder_Click(object sender, EventArgs e)
        {
            int noBoots = int.Parse(txtNoBoots.Text) * nBoots;
            int yesBoots = int.Parse(txtYesBoots.Text) * yBoots;
            int nyBoots = noBoots + yesBoots;

            txtCRSNoBoots.Text = "" + noBoots;
            txtCRSBoots.Text = "" + yesBoots;
            txtCRSTotal.Text = "" + nyBoots;

            drsBoots += yesBoots;
            drsnBoots += noBoots;
            drsTotal = (drsBoots +drsnBoots);

            txtDRSBoots.Text = "" + drsBoots;
            txtDRSNoBoots.Text = "" + drsnBoots;
            txtDRSTotal.Text = "" + drsTotal;
            txtDRSTotalAvg.Text = "" + (drsTotal/orders);

            orders++;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtName.Text = "";
            txtIdNum.Text = "";
            txtNoBoots.Text = "";
            txtYesBoots.Text = "";
            txtCRSBoots.Text = "";
            txtCRSNoBoots.Text = "";
            txtCRSTotal.Text = "";
        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {

            txtName.Text = "";
            txtIdNum.Text = "";
            txtNoBoots.Text = "";
            txtYesBoots.Text = "";
            txtCRSBoots.Text = "";
            txtCRSNoBoots.Text = "";
            txtCRSTotal.Text = "";
            txtDRSBoots.Text = "";
            txtDRSNoBoots.Text = "";
            txtDRSTotal.Text = "";
            txtDRSTotalAvg.Text = "";

            drsBoots = 0;
            drsnBoots = 0;
            drsTotal = 0;
            orders = 1;

            
            
        }
    }
}
