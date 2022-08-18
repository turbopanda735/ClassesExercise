using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesExercise
{
    internal class Program
    {
        public static void Main()
        {
            var myCar = new Car
            {
                Make = "Subaru",
                Model = "Outback",
                Year = 2023
            };
            Console.WriteLine($"my current car is a {myCar.Year} {myCar.Make} {myCar.Model}");
            var myDreamCar = new Car("Ford", "F-150 Lightning", 2023);
            Console.WriteLine($"my current car is a {myDreamCar.Year} {myDreamCar.Make} {myDreamCar.Model}");

            var dreamList = new List<Car>();
            dreamList.Add(myDreamCar);
            dreamList.Add(myCar);
            foreach (Car car in dreamList)
            {
                car.PrintCarInfo();
            }
            var myHouse = new House();
            Console.WriteLine("Please enter the year your house was built, follwed by the style, the city, and finally a 'yes' or 'no' for if it was expensive or not...");
            myHouse.YearBuilt = int.Parse(Console.ReadLine());
            myHouse.Style = Console.ReadLine();
            myHouse.City = Console.ReadLine();
            myHouse.IsExpensive = myHouse.NotExpensive(Console.ReadLine());
            var dreamHouse = new House()
            {
                YearBuilt = 1901,
                Style = "Victorian",
                City = "Somerville",
            };
            var dreamHouseList = new List<House>();

            dreamHouseList.Add(myHouse);
            dreamHouseList.Add(dreamHouse);
            foreach (House house in dreamHouseList)
            {
                house.PrintInfo();
            }
        }
    }
}