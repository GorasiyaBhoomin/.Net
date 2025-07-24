using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calsmethod
{
     class Calsmethod
    {
        static int Add(int a, int b)
        {
            return a + b;
        }
        static int Sub(int a, int b)
        {
            return a - b;
        }
        static int Mul(int a, int b)
        {
            return a * b;
        }
        static int Div(int a, int b)
        {
            return a / b;
        }
        static void Main(string[] args)
        {
            int a=20,b=20;
            int ra;
            ra = Add(a, b);
            Console.WriteLine("Addition:" + ra);
            ra = Sub(a, b);
            Console.WriteLine("Substaction:" + ra);
            ra = Mul(a, b);
            Console.WriteLine("Multiplication:" + ra);
            ra = Div(a, b);
            Console.WriteLine("Division:" + ra);



        }
    }

}
