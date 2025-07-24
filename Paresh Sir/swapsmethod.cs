using System;


namespace Dotnet
{
    class swapsmethod
    {
        static void swap(ref int a,ref int b)
        {
            int c=a;
            a = b;
            b = c;
            
        }
        static void Main()
        {
            int a=10; int b=20;
            Console.WriteLine("before swap: a={0)} and b={1}",a,b);
            swap(ref a,ref b);
            Console.WriteLine("after swap: a={0} and b={1}",b,a);

            
        }
    }

}
