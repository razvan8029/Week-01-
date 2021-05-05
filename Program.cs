using System;
using City.src.model;

namespace City
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car("Audi", 2020, "SV29LRZ");
            Console.WriteLine(car);

            Street street = new Street(19, "Wall Street");
            Console.WriteLine(car);

            Building building = new Building("Empire State", 1920);
            Console.WriteLine(building);
        }
    }
}