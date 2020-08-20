using System;

namespace ConsoleApp1
{
    class Program
    {
        class Password
        {
            public string[] Pass = new string[2];

            public static void addPass()
            {
                Console.WriteLine("Enter 2 Password:");
                Password password = new Password();

                for (int i = 0; i < password.Pass.Length; i++)
                {
                    password.Pass[i] = Console.ReadLine();
                }
                Console.WriteLine("\nOK thank you!");
            }
        }
        class Logger
        {
            public static void controlPass()
            {
                Password password = new Password();
                Console.WriteLine("Enter you pass: ");
                string peoplePass = Console.ReadLine();

                int count1 = 0;
                int count2 = 0;

                for (int i = 0; i < password.Pass.Length; i++)
                {
                    if (password.Pass[i] == peoplePass)
                    {
                        count1++;
                    }
                    if (password.Pass[i] != peoplePass)
                    {
                        count2++;
                    }
                }
                if (count1 < count2)
                {
                    Console.WriteLine("Great!");
                }
                else
                {
                    Console.WriteLine("ERROR");
                }
                var u
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
            Logger.controlPass();
            LogicForBmw();
        }

    }
}