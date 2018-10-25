using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bonus16
{
    class Program
    {
        //Comment
        static void Main(string[] args)
        {
            var app = new CarApp();

            app.PopulateCars();

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("\tMake\tModel\tYear\tPrice");
            Console.WriteLine();

            foreach (var car in app.Cars)
            {
                Console.WriteLine(car.ToString());
            }

            Console.ReadKey();
        }
    }
}
