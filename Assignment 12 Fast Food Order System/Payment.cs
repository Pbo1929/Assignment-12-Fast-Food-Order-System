using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_12_Fast_Food_Order_System
{
    class Payment
    {
        private DrinkItem[] di = new DrinkItem[100];
        private FoodItem[] fi = new FoodItem[100];
        private int fiCount = 0;
        private int diCount = 0;

        public Payment()
        {
        }

        public void AddFoodItem(FoodItem f)
        {
            fi[fiCount] = f;
            fiCount++;
        }

        public void AddDrinkItem(DrinkItem d)
        {
            di[diCount] = d;
            diCount++;
        }

        public FoodItem GetFoodItem(int i)
        {
            return fi[fiCount];
        }
        public DrinkItem GetDrinkItem(int i)
        {
            return di[diCount];
        }

        public int FindPrice(Item[] pl, string c)
        {
            for (int i = 0; i < pl.Length; i++)
            {
                if (pl[i] != null)
                {
                    pl[i].GetPrice();
                }
            }
            return 0;
        }

        public double CalculateBill(Item[] pl)
        {
            string code = "";
            double price = 0;
            int quantity = 0;
            double total = 0;
            for (int i = 0; i < di.Length; i++)
            {
                if (di[i] != null)
                {
                    code = di[i].GetItemCode();
                    price = FindPrice(pl, code);
                    quantity = di[i].GetQuantity();
                    total = price * quantity;
                }
            }
            for (int i = 0; i < fi.Length; i++)
            {
                if (fi[i] != null)
                {
                    code = fi[i].GetItemCode();
                    price = FindPrice(pl, code);
                    quantity = fi[i].GetQuantity();
                    total = price * quantity;
                }
            }
            return total;
        }
    }
}
