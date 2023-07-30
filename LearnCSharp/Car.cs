using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnCSharp
{
    internal class Car
    {
        private string Make { get; set; }
        private string Model { get; set; }
        private int Year { get; set; }
        private double price { get; set; }
        public bool IsAvailable { get; set; }

        public Car(string make, string model, int year, double price)
        {
            Make = make;
            Model = model;
            Year = year;
            Price = price;
        }

        public double Price
        {
            get { return price; }
            set
            {
                if (value <= 0)
                {
                    price = 0;
                    IsAvailable = false;
                }
                else
                {
                    price = value;
                    IsAvailable = true;
                }

            }
        }
    }
}
