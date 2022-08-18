using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesExercise
{
    internal class House
    {
        public House() { }

        public bool IsExpensive = true;
        public int YearBuilt { get; set; }
        public string City { get; set; }
        public string Style { get; set; }

        public void PrintInfo()
        {
            Console.WriteLine($"This house is a {Style} house in {City}. It was built in {YearBuilt} and it is {IsExpensive} that it's expensive.");
        }
        public bool NotExpensive(string housePrice)
        {
            bool output;
            switch (housePrice.ToLower())
            {
                default:
                    output = true; ;
                    break;
                case "no":
                    Console.WriteLine("what do you mean your house isnt expensive?? all houses are expensive!");
                    output = false;
                    break;
            }
            if (output == true)
                return true;
            else return false;
        }
    }
}
