using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_12_Fast_Food_Order_System
{
    class FoodItem
    {
        private string ItemCode;
        private int Quantity;

        public FoodItem(string ItemCode, int Quantity)
        {
            this.ItemCode = ItemCode;
            this.Quantity = Quantity;
        }

        public string GetItemCode()
        {
            return ItemCode;
        }

        public int GetQuantity()
        {
            return Quantity;
        }
    }
}
