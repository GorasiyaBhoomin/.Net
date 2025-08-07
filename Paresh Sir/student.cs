using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Student
    {
        private string enrolmentNo;
        private string firstName;
        private string lastName;

        public string EnrolmentNo
        {
            get { return enrolmentNo; }
            set { enrolmentNo = value; }
        }

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public void DisplayInfo()
        {
            Console.WriteLine("Enrolment No: " + EnrolmentNo);
            Console.WriteLine("First Name: " + FirstName);
            Console.WriteLine("Last Name: " + LastName);
        }
    }

    internal class Test
    {
        static void Main(string[] args)
        {
            Student obj = new Student();

            obj.EnrolmentNo = "2025CE123";
            obj.FirstName = "Gorasiya";
            obj.LastName = "Bhoomin";

            obj.DisplayInfo();
        }
    }
}
