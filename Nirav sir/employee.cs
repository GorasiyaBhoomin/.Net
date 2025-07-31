using System;
using System.Net;

namespace employee
{


    public class employee
    {

        int empId;
        string eName;
        double salary;
        public void getData(int empId, string eName, double salary)
        {
            this.empId = empId;
            this.eName = eName;
            this.salary = salary;

        }
        public void showData()
        {
            Console.WriteLine("EmpId:" + empId);
            Console.WriteLine("eName:" + eName);
            Console.WriteLine("salary:" + salary);


        }
    }
    internal class employee2
    {

        public static void Main(string[] args)
        {
            employee e1 = new employee();
            e1.getData(111,"aaa",200.0);
            e1.showData();

            employee e2 = new employee();
            e1.getData(2122,"bbb",300);
            e1.showData();

            //if (e1.salary()>e2.salary())
            //    e1.showData();
            //else
            //    e2.showData();

        }
    }
}
