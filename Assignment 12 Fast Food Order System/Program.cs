using System;

namespace Assignment_12_Fast_Food_Order_System
{
    class Program
    {
        static void Main(string[] args)
        {
            Item[] pl = new Item[]
            {
                new Item("D1", "Coke", 1.2),
                new Item("D2", "Pepsi", 5.2),
                new Item("D3", "Sprite", 10.5),
                new Item("F1", "Chicken", 11.2),
                new Item("F2", "Pizza", 7.3),
                new Item("F3", "Burger", 3),
            };

            Payment PremLunch = new Payment();
            PremLunch.AddDrinkItem(new DrinkItem("D1", 2));
            PremLunch.AddFoodItem(new FoodItem("F1", 10));

            Console.WriteLine("FAST FOOD");
            Console.WriteLine("");
            for (int i = 0; i < pl.Length; i++)
            {
                Console.WriteLine("ITEM CODE:" + pl[i].GetItemCode() + " NAME:" + pl[i].GetName() + " PRICE:" + pl[i].GetPrice());

                Console.WriteLine("PRICE OF COKE:");
                PremLunch.FindPrice(pl, "D1");

                Console.WriteLine("BILL:");
                Console.WriteLine(PremLunch.CalculateBill(pl));
            }

        }
        
    }
}
