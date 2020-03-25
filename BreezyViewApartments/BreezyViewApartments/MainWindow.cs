using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * Create a project named BreezyViewApartments that contains a Form for an apartment rental service. 
 * Allow the user to choose a number of bedrooms, number of baths, and view—street or lake. 
 * After the user makes selections, display the monthly rent, 
 * which is calculated using a base price of $450, $550, or $700 per month 
 * for a one-, two-, or three-bedroom apartment, respectively. 
 * $75 is added to the base price for more than one bath, 
 * and $50 additional is added to the price for a lake view. 
 * Use the Controls that you think are best for each function. 
 * Label items appropriately, and use fonts and colors to achieve an attractive design.
*/

namespace BreezyViewApartments
{
    public partial class MainWindow : Form
    {
        Computation C = new Computation();
        public MainWindow()
        {
            InitializeComponent();
            initialSet();
        }
        public void initialSet()
        {
            decimal temp = 0.00m;
            labelBedPrice.Text = "+ " + temp.ToString("C");
            labelBathPrice.Text = "+ " + temp.ToString("C");
            labelViewPrice.Text = "+ " + temp.ToString("C");
            labelTotalPrice.Text = "TOTAL MONTHLY RENT: " + temp.ToString("C");
        }


        private void BedroomChange(object sender, EventArgs e)
        {
            int bedSelected;
            bedSelected = comboBoxBedroom.SelectedIndex;
            C.NumberOfBeds = bedSelected;
            labelBedPrice.Text = C.getBedString(bedSelected);
            labelTotalPrice.Text = TotalFormatting();
        }

        private void BathChanged(object sender, EventArgs e)
        {
            int bathSelected;
            bathSelected = comboBoxBath.SelectedIndex;
            C.NumberOfBaths = bathSelected;
            labelBathPrice.Text = C.getBathString(bathSelected);
            labelTotalPrice.Text = TotalFormatting();
        }

        private void ViewChanged(object sender, EventArgs e)
        {
            int viewSelected;
            viewSelected = comboBoxView.SelectedIndex;
            C.ViewSelected = viewSelected;
            labelViewPrice.Text = C.getViewString(viewSelected);
            labelTotalPrice.Text = TotalFormatting();
        }

        private string TotalFormatting()
        {
            string TotalPrice = "";
            TotalPrice = "TOTAL MONTHLY RENT: " + C.TotalPrice.ToString("C");
            return TotalPrice;
        }

        private void ButtonReset_Click(object sender, EventArgs e)
        {
            initialSet();
            comboBoxBedroom.Text = "";
            comboBoxBath.Text = "";
            comboBoxView.Text = "";
            C.TotalPrice = 0;
        }
    }
}
