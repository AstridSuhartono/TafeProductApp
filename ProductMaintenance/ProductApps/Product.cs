using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductApps
{
    class Product
    {
        private decimal price;
        private int quantity;
        private decimal totalPayment;
        private decimal delivery;
        private decimal wrapping;
        private decimal gst;
        private decimal totalCharge;
        private decimal totalWrap;
        private decimal totalGst;
        static decimal gstRate = 1.1M;
        private decimal Price
        {
            get { return price; }
            set { price = value; }
        }

        private int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }

        public decimal TotalPayment
        {
            get { return totalPayment; }
            set { totalPayment = value; }
        }


        private decimal Delivery
        {
            get { return delivery; }
            set { delivery = value; }
        }


        private decimal Wrapping
        {
            get { return wrapping; }
            set { wrapping = value; }
        }

        private decimal GST
        {
            get { return gst; }
            set { gst = value; }
        }

        public decimal TotalCharge
        {
            get { return totalCharge; }
            set { totalCharge = value; }
        }

        public decimal TotalWrap
        {
            get { return totalWrap; }
            set { totalWrap = value; }
        }

        public decimal TotalGst
        {
            get { return totalGst; }
            set { totalGst = value; }
        }
        //Constructor for Product
        public Product(decimal price, int quantity)
        {
            Price = price;
            Quantity = quantity;
        }

        //Calculate the total payment
        public void calTotalPayment()
        {
            TotalPayment = Price * Quantity;
        }

        //calculate the total charge
        public void calTotalCharge()
        {
            TotalCharge = TotalPayment + 25;
        }

        //calculate the total wrap
        public void calTotalWrap()
        {
            TotalWrap = TotalCharge + 5;
        }

        //calculate the total gst
        public void calTotalGst()
        {
            TotalGst = TotalWrap * gstRate;
        }
    }
}
