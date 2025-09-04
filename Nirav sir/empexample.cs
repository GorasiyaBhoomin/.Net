using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array1
{
    public class demo2
    {
        int empcode;
        string eName;
        string designation;
        string instname;
        float basicpay;
        //public void getData(int empId, string eName, double salary)
        //{
        //    this.empId = empId;
        //    this.eName = eName;
        //    this.salary = salary;

        //}
        public void showData()
        {
            Console.WriteLine("empcode:" + empcode);
            Console.WriteLine("eName:" + eName);
            Console.WriteLine("designation:" + designation);
            Console.WriteLine("instname:" + instname);
            Console.WriteLine("basicpay:" + basicpay);


        }



    }
    internal class staticdemo
    {

        static void Main(string[] args)
        {
            employee emp= new employee();
            emp.showData();

        }
    }
}

