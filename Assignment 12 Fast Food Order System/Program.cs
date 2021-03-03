using System;
using System.IO;

namespace Assignment_12_Fast_Food_Order_System
{
    class Program
    {
        static void Main(string[] args)
        {
            Item[] pl = new Item[100];
            Payment PremLunch = new Payment();

            StreamReader FileReader = new StreamReader("food.csv");
            string line = FileReader.ReadLine();

            int count = 0;
            Console.WriteLine("PremLunch Menu");
            Console.WriteLine("");
            while ((line = FileReader.ReadLine()) != null)
            {
                string[] cells = line.Split(',');
                string code = cells[0];
                string name = cells[1];
                double price = Convert.ToDouble(cells[2]);
                Console.WriteLine("{0} {1} {2}", code, name, price);
                pl[count] = new Item(code, name, price);
                count++;
            }
            Menu(PremLunch, pl);
        }

        public static void Menu(Payment PremLunch, Item[] pl)
        {
            bool i = false;
            string input;
            int input2;
            while (i == false)
            {

                Console.WriteLine("");
                Console.WriteLine("Type 1 to select food.");
                Console.WriteLine("Type 2 to select drink.");
                Console.WriteLine("Type 3 checkout.");
                Console.WriteLine("Type 4 to exit.");
                input = Console.ReadLine();
                input2 = Convert.ToInt32(input);

                if (input2 == 1)
                {
                    SelectFood(PremLunch, pl);
                }
                if (input2 == 2)
                {
                    SelectDrink(PremLunch, pl);
                }
                if (input2 == 3)
                {
                    CheckOut(PremLunch, pl);
                }
                if (input2 == 4)
                {
                    break;
                }
            }
        }

        public static void SelectFood(Payment PremLunch, Item[] pl)
        {
            int Price;
            string ReadFood = "";
            string ReadFoodQuantity = "";
            int ReadFoodQuantity2 = 0;
            string Read = "";

            bool Exit = false;
            while (Exit != true)
            {
                Console.WriteLine("");

                Console.WriteLine("Enter Food ID:");
                ReadFood = Console.ReadLine();

                Console.WriteLine("Enter Food Quantity:");
                ReadFoodQuantity = Console.ReadLine();
                ReadFoodQuantity2 = Convert.ToInt32(ReadFoodQuantity);

                PremLunch.AddFoodItem(new FoodItem(ReadFood, ReadFoodQuantity2));
                Price = PremLunch.FindPrice(pl, ReadFood);
                Console.WriteLine(Price);

                Console.WriteLine("Are you done? ( Y/N )");
                Read = Console.ReadLine();
                if (Read == "Y")
                {
                    Exit = true;
                }
                else if (Read == "N")
                {
                    Exit = false;
                }
            }
        }

        public static void SelectDrink(Payment PremLunch, Item[] pl)
        {
            string ReadDrink = "";
            string ReadDrinkQuantity = "";
            int ReadDrinkQuantity2 = 0;
            string Read = "";

            bool Exit = false;
            while (Exit != true)
            {
                Console.WriteLine("");

                Console.WriteLine("Enter Drink ID:");
                ReadDrink = Console.ReadLine();

                Console.WriteLine("Enter Drink Quantity:");
                ReadDrinkQuantity = Console.ReadLine();

                ReadDrinkQuantity2 = Convert.ToInt32(ReadDrinkQuantity);

                PremLunch.AddDrinkItem(new DrinkItem(ReadDrink, ReadDrinkQuantity2));
                PremLunch.FindPrice(pl, ReadDrink);

                Console.WriteLine("Are you done? ( Y/N )");
                Read = Console.ReadLine();
                if (Read == "Y")
                {
                    Exit = true;
                }
                else if (Read == "N")
                {
                    Exit = false;
                }
            }
        }

        public static void CheckOut(Payment PremLunch, Item[] pl)
        {
            Console.WriteLine("BILL:");
            for (int i = 0; i < 100; i++)
            {
                    Console.WriteLine(PremLunch.CalculateBill(pl));
                
            }

        }
    }
}

