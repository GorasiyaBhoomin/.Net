using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array1
{
    public class demo2
    {

        int x;
        static int y = 20;
        public demo2()
        {
        }
        public demo2(int x)
        {
            this.x = x;
        }

        public static int addnum()
        {
            demo2 ob = new demo2(30);
            return (ob.x + y);
        }

        public void show()
        {
            Console.WriteLine("x is:" + x);
            Console.WriteLine("y is:" + y);
        }

    }
    internal class staticdemo
    {

        static void Main(string[] args)
        {
            demo2 ob = new demo2(56);
            Console.WriteLine("Addition is:" + demo2.addnum());
            ob.show();
        }
    }
}
