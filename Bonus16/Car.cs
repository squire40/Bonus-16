using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bonus16
{
    public class Car
    {
        private string _make;
        private string _model;
        private int _year;
        private double _price;

        public string Make {
            get { return _make; }
            set { _make = value; }
        }

        public string Model
        {
            get { return _model; }
            set { _model = value; }
        }

        public int Year
        {
            get { return _year; }
            set { _year = value; }
        }

        public double Price
        {
            get { return _price; }
            set { _price = value; }
        }

        public Car(string make, string model, int year, double price)
        {
            _make = make;
            _model = model;
            _year = year;
            _price = price;
        }

        public Car()
        {
            _make = null;
            _model = null;
            _year = 0;
            _price = 0;
        }

        public override string ToString()
        {
            return $"\t{_make}\t{_model}\t{_year}\t{_price.ToString("C")}";
        }
    }
}
