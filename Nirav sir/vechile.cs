using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Vehical
    {
        protected String Type;
        protected int Speed;
        protected String Fuel;
        protected int Milege;

        public Vehical(string type, int speed, string fuel, int milege)
        {
            Type = type;
            Speed = speed;
            Fuel = fuel;
            Milege = milege;
        }
    }

    class Car : Vehical
    {
        int NoOfGears;
        String Model;
        public Car(string type, int speed, string fuel, int milege, int noOfGears, string model) : base(type, speed, fuel, milege)
        {
            NoOfGears = noOfGears;
            Model = model;
        }

        public void Show()
        {
            Console.WriteLine("Details of Car:");
            Console.WriteLine("----------------");
            Console.WriteLine("Type of Car:" + Type);
            Console.WriteLine("Speed of Car:" + Speed);
            Console.WriteLine("Fuel of Car:" + Fuel);
            Console.WriteLine("Milege of Car:" + Milege);
            Console.WriteLine("No of Gears:" + NoOfGears);
            Console.WriteLine("Model is:" + Model);
        }
    }
    internal class InheritVehical
    {
        public static void Main(string[] args)
        {
            Car car = new Car("Creta", 200, "Petrol", 15, 6, "Hyndai");
            car.Show();
        }
    }
}
