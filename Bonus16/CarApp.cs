using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bonus16
{
    public class CarApp
    {
        public List<Car> Cars { get; set; }

        public void PopulateCars()
        {
            Cars = new List<Car>();
            string input = "", make = "", model = "";
            bool isValid = false;
            int numberOfCars = 0;
            int year = 0;
            double price = 0;

            Console.WriteLine("Welcome to the Car App!!");

            do
            {
                isValid = true;
                Console.WriteLine("How many cars would you like to create?");
                try
                {
                    numberOfCars = int.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    isValid = false;
                    Console.WriteLine("Invalid input, enter an integer.");
                }
            } while (!isValid);

            for (int i = 0; i < numberOfCars; i++)
            {
                do
                {
                    isValid = true;
                    Console.WriteLine("Enter Make");
                    input = Console.ReadLine();
                    if (string.IsNullOrWhiteSpace(input))
                    {
                        Console.WriteLine("Invalid input.  Enter an integer.");
                        isValid = false;
                    }
                    else
                    {
                        make = input;
                    }
                } while (!isValid);
                do
                {
                    isValid = true;
                    Console.WriteLine("Enter Model");
                    input = Console.ReadLine();
                    if (string.IsNullOrWhiteSpace(input))
                    {
                        Console.WriteLine("Invalid input.  Enter an integer.");
                        isValid = false;
                    }
                    else
                    {
                        model = input;
                    }
                } while (!isValid);
                do
                {
                    isValid = true;
                    Console.WriteLine("Enter Year");
                    try
                    {
                        year = int.Parse(Console.ReadLine());
                    }
                    catch (Exception)
                    {
                        isValid = false;
                        Console.WriteLine("Invalid input, enter an integer.");
                    }
                } while (!isValid);
                do
                {
                    isValid = true;
                    Console.WriteLine("Enter Price");
                    try
                    {
                        price = double.Parse(Console.ReadLine());
                    }
                    catch (Exception)
                    {
                        isValid = false;
                        Console.WriteLine("Invalid input, enter a double.");
                    }
                } while (!isValid);

                Car c = new Car(make, model, year, price);
                Cars.Add(c);
            }

        }
    }
}
