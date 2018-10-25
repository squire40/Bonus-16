using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bonus16
{
    public class CarApp
    {
        private List<Car> _cars;

        public void PopulateCars()
        {
            _cars = new List<Car>();
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
                input = Console.ReadLine();

                if (!Validator.IsValidInt(input))
                {
                    isValid = false;
                    Console.WriteLine("Invalid input, enter an integer.");
                }
                else
                {
                    numberOfCars = int.Parse(input);
                }
            } while (!isValid);

            for (int i = 0; i < numberOfCars; i++)
            {
                do
                {
                    isValid = true;
                    Console.WriteLine("Enter Make");
                    input = Console.ReadLine();
                    if (!Validator.IsValidString(input))
                    {
                        Console.WriteLine("Invalid input.");
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
                    if (!Validator.IsValidString(input))
                    {
                        Console.WriteLine("Invalid input.");
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
                    input = Console.ReadLine();
                    if (!Validator.IsValidInt(input))
                    {
                        isValid = false;
                        Console.WriteLine("Invalid input, enter an integer.");
                    }
                    else
                    {
                        year = int.Parse(input);
                    }
                } while (!isValid);
                do
                {
                    isValid = true;
                    Console.WriteLine("Enter Price");
                    input = Console.ReadLine();
                    if (!Validator.IsValidDouble(input))
                    {
                        isValid = false;
                        Console.WriteLine("Invalid input, enter a double.");
                    }
                    else
                    {
                        price = double.Parse(input);
                    }
                } while (!isValid);

                Car c = new Car(make, model, year, price);
                _cars.Add(c);
            }

        }

        public void DisplayCarList()
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("\tMake\tModel\tYear\tPrice");
            Console.WriteLine();

            foreach (var car in _cars)
            {
                Console.WriteLine(car.ToString());
            }

        }
    }
}
