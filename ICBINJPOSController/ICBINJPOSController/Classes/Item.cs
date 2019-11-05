using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICBINJPOSController
{
    public class Item
    {
        private int quantity;

        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }

        //private int id;

        //public int Id
        //{
        //    get { return id; }
        //    set { id = value; }
        //}


        private string description;

        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        private string size;

        public string Size
        {
            get { return size; }
            set { size = value; }
        }


        private double price;

        public double Price
        {
            get { return price; }
            set { price = value; }
        }

        public Item(int quantity, string itemDesc, string size, double price)
        {
            this.description = itemDesc;
            this.size = size;
            this.quantity = quantity;
            this.price = price;
        }

        public Item(string itemDesc, double price)
        {
            this.description = itemDesc;
            this.price = price;
        }

        
    }
}
