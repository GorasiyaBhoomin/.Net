using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class class1
    {
        static void Main(string[] args)
        {
            int[] a = new int[5] { 1, 2, 3, 4, 5 };
            //index wise interation
            for(int i = 0; i < a.Length;i++)
            {
                Console.WriteLine(a[i]);
            }
            foreach(int i in a)
            {
                Console.WriteLine(i);
            }
        }
    }
}
