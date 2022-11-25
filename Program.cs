using System.Security.Cryptography.X509Certificates;
using System;
using System.Linq;
using System.Runtime.InteropServices;
using System.Reflection;
namespace app
{
    class program
    {
        public static void Main(string[] agrs)
        {
            string name;
            int Book, Mode, Seat;
            int SeatPerCost = 299; // 1 : 299

            Console.Write("Enter name : ");
            name = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Your name "+name);

            // >> "Choose menu"
            Console.Write("How many do you want to booking table : ");
            Book = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your booking "+Book+" table ");

            do
            {
                Console.Write("Shabu (1)/ butter roast (2) / All (3): ");
                Mode = Convert.ToInt32(Console.ReadLine());


                if (Mode == 1) // if else
                {
                    Console.WriteLine("You select Shabu");
                }
                else if (Mode == 2)
                {
                    Console.WriteLine("You select butter roast");
                }
                else if (Mode == 3)
                {
                    Console.WriteLine("You select All");
                }
                else
                {
                    Console.WriteLine("You must select 1/2/3 🙂 ");
                }
            } while (Mode > 3 || Mode < 1);


            // >> "Choose day" // Use <array> 
            string[] Days = {
                "Monday",
                "Tuesday",
                "Wednesday",
                "Thursday",
                "Friday",
                "Saturday",
                "Sunday",};
            Console.Write("Enter day number to select the day | From monday-sunday (1-7): ");
            int DayId = Convert.ToInt32(Console.ReadLine());
            string SelectDay = Days.ElementAtOrDefault(DayId - 1); // out of array scope default = null
            if (SelectDay is null)
            {
                Console.WriteLine("Error Invalid Day.");
                return; // End Program...
            }
            else
            {
                Console.WriteLine("You choose to go on " + SelectDay);
            }

            // >> "How many people"
            Console.Write("How many people : ");
            Seat = Convert.ToInt32(Console.ReadLine());
            Console.Write("You have  " + Seat + "People");

            Console.WriteLine("This is you payment : " + Seat * 299);

            // >> "Choose drink / Based on seat"
            string[] ChoosenDrinks = new string[Seat]; // based on seat
            string[] Drinks = { // Use <array>
                "Water",
                "Coke",
                "Lemonade",
                "No-Drink",
            };
            Console.WriteLine("Choose your drink");
            for (int Index = 0; Index < Drinks.Length; Index++)
            {
                Console.WriteLine("{0}. {1}", Index + 1, Drinks[Index]);
            }
            for (int Index = 0; Index < Seat; Index++)
            {
                Console.Write("Seat#{0}, choose a drink: ", Index + 1);
                int SelectDrink = int.Parse(Console.ReadLine());
                string DrinkName = Drinks.ElementAtOrDefault(SelectDrink - 1); // out of array scope default = null
                if (DrinkName is null)
                {
                    Console.WriteLine("Invaild Drink");
                    return; // End Program...
                }
                else
                {
                    ChoosenDrinks[Index] = DrinkName; // add input data to
                }
            }
            for (int Index = 0; Index < ChoosenDrinks.Length; Index++)
            {
                Console.WriteLine("Seat Number's {0} --> {1}", Index + 1, ChoosenDrinks[Index]);
            }

            // loop do while 
            // >> "Choose period"
            int Self = 1;
            do
            { // Use <Loop>
                Console.WriteLine("The time period you will choose " + Self);
                Self++;
            } while (Self <= 3);
            Console.WriteLine(" this is time list\n18.00 pm- 19.00 pm (1)\n19.00 pm- 20.00 pm (2)\n20.00 pm- 21.00 pm (3) ");
            int Choice = 3;
            Console.Write("You choose : ");
            Choice = Convert.ToInt32(Console.ReadLine());
            
            switch (Choice)
            { // Use <swtich-case>
                case 1:
                    Console.WriteLine("18.00 pm- 19.30 pm"); break;
                case 2:
                    Console.WriteLine("19.00 pm- 20.00 pm"); break;
                case 3:
                    Console.WriteLine("20.00 pm- 21.00 pm"); break;
                default:
                    Console.WriteLine("No have this time"); return; // End Program...
            }

            // funtion or method 

            static int SumBirth(int birth)
            {
                int sum = 0;
                while (birth > 0)
                {
                    int e = birth % 10;
                    sum += e;
                    birth /= 10;
                }
                return sum;
            }

            Console.Write("Enter you birthday (day/month/year) here for discount : ");  // >> "Birthday Discount"
            int birth = Convert.ToInt32(Console.ReadLine());
            Console.Write("This is sum your biryth for using promotion\n You can use  " + SumBirth(birth) + "%  for a discount");

            float Discount;
            Discount = (SumBirth(birth) % 100) * (Seat * SeatPerCost);
            Console.WriteLine("\nYour discount is : " + (Discount / 100) + " bath");

            // >> "Total Cost (Result)"
            float TotalCost;
            TotalCost = (Seat * SeatPerCost) - (Discount / 100);
            Console.WriteLine("Your last payment : " + TotalCost + " bath");
        }

    }
}