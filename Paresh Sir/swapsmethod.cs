using System;


namespace Dotnet
{
    /// <summary>
    /// hello i am comment 1
    /// </summary>
    class swapsmethod
    {
        /// <summary>
        /// usned to share % value
        /// </summary>
        //int a;
        /// <summary>
        /// This method is used to swap values of two variables
        /// </summary>
        /// <param name="a">First ref parameter or varialble</param>
        /// <param name="b">Second ref parameter or varialble</param>
        /// <returns></returns>
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
