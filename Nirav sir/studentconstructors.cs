using System;
using System.Net;

namespace Constructor
{


    class studentconstructors

    //default constructor
    //{
    //    int roll;
    //    string name;

    //    public studentconstructors()//default constructor
    //    {
    //        roll = 51;
    //        name = "hlool";
    //    }
        public void showData()
    {
        Console.WriteLine("Roll: " + roll);
        Console.WriteLine("Name: " + name);
    }
    //}

    //default constructor
    {
        public studentconstructors(int x,int y)
        {

        }
        public studentconstructors(studentconstructors s)
        {
            
        }
    }
    internal class demo
    {
        public static void Main(string[] args)
        {
            //studentconstructors s1 = new studentconstructors();
            //s1.showData();
            studentconstructors[] s = new studentconstructors[2];
            for (int i = 0; i < s.length; i++)
            {
                args[i] = new studentconstructors;
            }
            Console.WriteLine("Student Details are:");
            for (int i=0;i<s.length,int++)
            {
                s[i].showdata();
            }
        }
    }
}
