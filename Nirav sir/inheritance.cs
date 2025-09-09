using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array1
{
    public class Demo1
    {
        class A
        {
            protected int x;   // field
            public A(int x)
            {
                Console.WriteLine("Constructor of base class A");
                this.x = x;
            }
            public void methodA1()
            {
                Console.WriteLine("Method A1 from class A");
                Console.WriteLine("Value of x is: " + x);
            }
            public void methodA2()
            {
                Console.WriteLine("Method A2 from class A");
            }

            // ✅ property for x (inside A)
            public int X
            {
                get { return x; }
            }
        }

        class B : A
        {
            int y;
            public B(int x, int y) : base(x)
            {
                Console.WriteLine("Constructor of derived class B");
                this.y = y;
            }
            public void methodB1()
            {
                methodA2();
                Console.WriteLine("Method B1 from class B");
                Console.WriteLine("Value of y is: " + y);
            }

            // ✅ property for y
            public int Y
            {
                get { return y; }
            }
        }

        internal class PropertyDemo
        {
            static void Main(string[] args)
            {
                B obj = new B(10, 20);
                obj.methodA1();
                obj.methodB1();

                double avg = (obj.X + obj.Y) / 2.0;
                Console.WriteLine("Average is: " + avg);
            }
        }
    }
}
