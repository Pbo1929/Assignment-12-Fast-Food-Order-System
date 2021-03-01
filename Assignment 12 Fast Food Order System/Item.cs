using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_12_Fast_Food_Order_System
{
    class Item
    {
        private string ItemCode;
        private string Name;
        private double Price;

        public Item(string ItemCode, string Name, double Price)
        {
            this.ItemCode = ItemCode;
            this.Name = Name;
            this.Price = Price;
        }


        public string GetItemCode()
        {
            return ItemCode;
        }

        public string GetName()
        {
            return Name;
        }

        public double GetPrice()
        {
            return Price;
        }
    }
}
