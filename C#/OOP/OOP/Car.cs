using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class Car
    {
        // member variables
        //private hides the variable from other classes, making it encapsulated
        //Backing fields of the Model, Brand, and IsLuxury properties
        private string _model = ""; // default value is null for reference types
        private string _brand = "";
        private bool _isLuxury; // default value is false for bool

        // properties
        public string Model
        {
            get { return _model; }
            set { _model = value; }
        }
        public string Brand
        {
            get { 
                if (IsLuxury)
                    return _brand + " - Luxury Edition";
                return _brand;
            }
            set { 
                if (string.IsNullOrEmpty(value)) 
                {
                    Console.WriteLine("Brand cannot be null or empty.");
                    _brand = "DefaultValue";
                }
                else
                {
                    _brand = value;
                }
                   
            }
        }

        public bool IsLuxury { get => _isLuxury; set => _isLuxury = value; }

        public Car(string model,string brand,bool isLuxury) { 
            Model = model;
            Brand = brand;
            IsLuxury = isLuxury;
            Console.WriteLine("Car created: " + _brand + " "+ model);
        }

        public void Drive()
        {
            Console.WriteLine("Driving the " + Model + " by " + Brand);
        }
    }
}
