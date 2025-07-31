using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Demo
{
     class MethodOverloadingDemo
    {
        void sum(int x,int y)
        {
            Console.WriteLine("sum of integers :"+(x+y));
        }
        void sum(int x,float y)
        {

        }
        static void Main(string[] args)
        {

            Console.ReadLine();
        }
    }
}
