using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace .Net
{
    public class Demo1
    {
        int x; //private member od class
        int y;

        public Demo1(int x, int y)
        {
            this.x = x; this.y = y;
        }
        public int X
        {
            set { x = value; }
            //get { return x; }   //read write property
        }
        public int Y
        {
            set { y = value; }
            //get { return y; }
        }
    }
    internal class Propertdemo
    {
        static void Main(string[] args)
        {
            Demo1 ob = new Demo1(1000, 200);
            //ob.X = 50;
            Console.WriteLine("value of private x:" + ob.X);
            //ob.Y = 150;
            Console.WriteLine("value of private x:" + ob.Y);
            Console.WriteLine("value of private x and y:" + (ob.X + ob.Y));
        }
    }
}


//properties in c#:
//    to access private members of class from outside
//    encapsulation - private
//    special methods -> accessors
//    set and get
//intermediate - only to transfer the data
//set: property is IServiceProvider used to set values
//get: property is used to retrive the values



