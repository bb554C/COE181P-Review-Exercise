using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BreezyViewApartments
{
    class Computation
    {
        private int numberOfBeds = 0;
        private int numberOfBaths = 0;
        private int viewSelected = 0;
        private decimal totalPrice = 0;
        private decimal[] bedPriceArray = { Convert.ToDecimal(450.00), Convert.ToDecimal(550.00), Convert.ToDecimal(700.00)};
        private decimal[] bathPriceArray = { Convert.ToDecimal(00.00), Convert.ToDecimal(75.00)};
        private decimal[] viewPriceArray = { Convert.ToDecimal(00.00), Convert.ToDecimal(50.00) };

        public int NumberOfBeds
        {
            get { return numberOfBeds; }
            set { numberOfBeds = value; }
        }

        public int NumberOfBaths
        {
            get { return numberOfBaths; }
            set { numberOfBaths = value; }
        }

        public int ViewSelected
        {
            get { return viewSelected; }
            set { viewSelected = value; }
        }

        public decimal TotalPrice
        {
            get { return totalPrice; }
            set { totalPrice = value; }
        }

        public string getBedString(int bedSelected)
        {
            string bedPrice = "";
            NumberOfBeds = bedSelected;
            bedPrice = "+ " + bedPriceArray[NumberOfBeds].ToString("C");
            computeTotal();
            return bedPrice;
        }

        public string getBathString(int bathSelected)
        {
            string bathPrice = "";
            numberOfBaths = bathSelected;
            int i = 0;
            if (numberOfBaths > 0)
            {
                i = 1;
            }
            bathPrice = "+ " + bathPriceArray[i].ToString("C");
            computeTotal();
            return bathPrice;
        }

        public string getViewString(int viewSelectedTMP)
        {
            string viewPrice = "";
            viewSelected = viewSelectedTMP;
            viewPrice = "+ " + viewPriceArray[viewSelected].ToString("C");
            computeTotal();
            return viewPrice;
        }

        public void computeTotal()
        {
            int i = 0;
            if(numberOfBaths > 0)
            {
                i = 1;
            }
            TotalPrice = 0;
            TotalPrice = bedPriceArray[NumberOfBeds] + bathPriceArray[i] + viewPriceArray[viewSelected];
        }
    }
}
