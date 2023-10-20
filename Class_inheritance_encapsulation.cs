using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Car car = new Car();
            car.ModelName = "Camaro";
            Console.WriteLine(car.ModelName);
            car.Year = 2023;
            Console.WriteLine(car.Year);
            car.year = 2022;
            Console.WriteLine(car.Year);
            Console.WriteLine(car.year);

            car.Marka = "chevrolet";
            Console.WriteLine(car.Marka);

            sportCar sportcar = new sportCar();
            Console.WriteLine("\n" +sportcar.ModelName);

            sportcar.ModelName = "Kia";
            Console.WriteLine(sportcar.ModelName);


        }
    }

    class Car
    {
        private string modelName;
        public string ModelName
        {
            get { return modelName; }
            set { modelName = value; }
        }
        public int year;
        public int Year
        {
            get => year;
            set => year = value;
        }
        public string marka;
        public string Marka
        {
            get;
            set;
        }
    }
    class sportCar : Car
    {

    }
}
