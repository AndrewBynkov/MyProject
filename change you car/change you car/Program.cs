using System;
using System.Dynamic;
using System.Security.Authentication;

namespace ConsoleApp1
{
    class Program
    {
        public class Password
        {
            internal string[] Pass = new string[2];

            public static void addPass()
            {
                Console.WriteLine("Enter 2 Password: ");
                Password password = new Password();

                for (int i = 0; i < password.Pass.Length; i++)
                {
                    password.Pass[i] = Console.ReadLine();
                }
                Console.Write("OK thank you! Enter you pass: ");

                string peoplePass;
                int count1 = 0;

                while (count1==0)
                {
                    peoplePass = Console.ReadLine();

                    for (int i = 0; i < password.Pass.Length; i++)
                    {
                        if (peoplePass == password.Pass[i])
                        {
                            count1++;
                        }
                    }

                    if (count1 == 0) 
                    {
                        Console.WriteLine($"Password {peoplePass} - incorrect. Try again");
                    }
                    else
                    {
                        Console.WriteLine($"Password - {peoplePass} correct! Sucsess!");
                    }
                }
            }

            class MarkSuperCar
            {
                public string[] MarkCar = new string[] { "BMW", "Audi", "Honda" };
            }
            class Model
            {
                public string[] CarModel = new string[] { "3-series", "7-long", "Accord" };
            }

            class Color
            {
                public string[] CarColor = new string[] { "Red", "Black", "Blue" };
            }

            public static void LogicForBmw()
            {
                MarkSuperCar markSuperCar = new MarkSuperCar();
                Model model = new Model();
                Color color = new Color();

                Console.Write("\nEnter you mark car: ");
                string CarForPeple = Console.ReadLine();

                int index = 0;
                for (int i = 0; i < markSuperCar.MarkCar.Length; i++)
                {
                    if (CarForPeple == markSuperCar.MarkCar[i])
                    {
                        index = i;
                        Console.WriteLine($"You car is: {CarForPeple} - {model.CarModel[index]} - {color.CarColor[index]} - data to day: {DateTime.Now}");
                    }
                    else
                    {
                        Console.WriteLine("Error");
                        break;
                    }
                }
            }

            static void Main(string[] args)
            {
                Password.addPass();
                LogicForBmw();
            }
        }
    }
}