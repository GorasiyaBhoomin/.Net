using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Demo
{
    class Employee
    {
        int Empid;
        string Name;
        string City;

        public Employee(int Empid,string Name)
        {
            this.Empid = Empid;
            this.Name = Name;
        }
        public Employee(int Empid, string Name,string City)
        {
            this.City = City;
        }
        static void Main(string[] args)
        {

            Console.ReadLine();
        }
    }
}
