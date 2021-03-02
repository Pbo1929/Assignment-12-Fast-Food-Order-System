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
            Menu(PremLunch);
        }

        public static void Menu(Payment PremLunch)
        {
            bool i = false;
            string input;
            int input2;
            while (i == false)
            {
                
                Console.WriteLine("");
                Console.WriteLine("Type 1 to select food.");
                Console.WriteLine("Type 2 checkout.");
                Console.WriteLine("Type 3 to get bill.");
                input = Console.ReadLine();
                input2 = Convert.ToInt32(input);

                if (input2 == 1)
                {
                    SelectFood(PremLunch);
                }
                if (input2 == 2)
                {
                    CheckOut(PremLunch);
                }
            }
        }

        public static void SelectFood(Payment PremLunch)
        {
            string Read = "";
            string Read2 = "";
            int Read3 = 0;
            string Read4 = "";

            bool Exit = false;
            while (Exit != true)
            {
                Console.WriteLine("");
                Console.WriteLine("Enter Food Name:");
                Read = Console.ReadLine();
                PremLunch.GetFoodItem(1);
                Console.WriteLine("Enter Food Quantity:");
                Read2 = Console.ReadLine();
                Read3 = Convert.ToInt32(Read2);
                Console.WriteLine("Are you done? ( Y/N )");
                Read4 = Console.ReadLine();
                if (Read4 == "Y")
                {
                    Exit = true;
                }
                else
                {
                    Exit = false;
                }

            }
        }

        public static void CheckOut(Payment PremLunch)
        {
            Console.WriteLine("BILL:");
            Console.WriteLine(PremLunch.CalculateBill(pl));
        }
    }
}
