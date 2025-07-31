using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calsmethod
{
    /// <summary>
    /// this class includes important methods
    /// </summary>
     class Calsmethod
    {
        /// <summary>
        /// usned to share % value
        /// </summary>
        int a;
        /// <summary>
        /// This method is used to swap values of two variables
        /// </summary>
        /// <param name="a">First ref parameter or varialble</param>
        /// <param name="b">Second ref parameter or varialble</param>
        /// <returns></returns>

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
