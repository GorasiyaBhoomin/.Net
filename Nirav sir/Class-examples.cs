using System;
using System.Net;

namespace Praticals
{
    internal class demoArray1
    {

        static void Main(string[] args)
        {

            //P1
            //int[] ary = new int[5]; //declaration of array
            ////initialization of array elements
            //ary[0] = 10;
            //ary[1] = 20;
            //ary[2] = 30;
            //ary[3] = 40;
            //ary[4] = 50;

            //Console.WriteLine(ary[0]);
            //Console.WriteLine(ary[1]);
            //Console.WriteLine(ary[2]);
            //Console.WriteLine(ary[3]);
            //Console.WriteLine(ary[4]);


            //P2
            //int[] ary = new int[] { 10, 20, 30, 40, 50 }; //initialization of array elemments
            //for (int i = 0; i < ary.Length; i++)
            //{
            //    Console.WriteLine(ary[i]);
            //}


            //P4
            //int[] ary = new int[] { 10, 20, 30, 40, 50 }; //initialization of array elemments
            //foreach (int i in ary)
            //{
            //    Console.WriteLine(i);
            //}


            //P5
            //int[] ary = new int[5];
            ////initilization of array elements
            //Console.WriteLine("enter array elements:");
            //for (int i = 0; i < ary.Length; i++)
            //{
            //    ary[i] = Int32.Parse(Console.ReadLine());
            //}
            //foreach (int i in ary)
            //{
            //    Console.WriteLine(i);
            //}

            //P6
            //int sum = 0;
            //for (int i = 0; i < args.Length; i++)
            //{
            //    sum = sum + ary[i];


            //}

            //P7
            //int[] ary = new int[5];
            ////initilization of array elements
            //Console.WriteLine("enter array elements:");
            //for (int i = 0; i < ary.Length; i++)
            //{
            //    ary[i] = Int32.Parse(Console.ReadLine());
            //}

            //int searchelement;
            //Console.WriteLine("enter a search element:");
            //searchelement=Convert.ToInt32(Console.ReadLine());
            //int flag = 0;
            //for (int i = 0; i < ary.Length; i++)
            //{
            //    if (ary[i] == searchelement)
            //    {
            //        flag = 1;
            //        break;
            //    }
            //}



            //P8
            //int[] ary = new int[5];
            ////initilization of array elements
            //Console.WriteLine("enter array elements:");
            //for (int i = 0; i < ary.Length; i++)
            //{
            //    ary[i] = Int32.Parse(Console.ReadLine());
            //}
            //for (int i = 0; i < ary.Length; i++) {

            //    for (int j = i + 1; j < ary.Length; j++) 
            //    {
            //        if (ary[i] > ary[j])
            //        {
            //            int temp = ary[i];
            //            ary[i] = ary[j];
            //            ary[j] = temp;
            //        }
            //    }
            //}
            //Console.WriteLine("Sorted elements are");
            //for (int i = 0; i < ary.Length; i++) 
            //{
            //Console.WriteLine(ary[i]);
            //}


            //P9
            int[] ary = new int[5];
            bool[] freq = new bool[ary.Length];
            //initilization of array elements
            Console.WriteLine("enter array elements:");
            for (int i = 0; i < ary.Length; i++)
            {
                ary[i] = Int32.Parse(Console.ReadLine());
            }
            for (int i = 0; i < ary.Length; i++)
            {
                if (freq[i] == true)
                    continue;

                int cnt = 1;
                for (int j = i + 1; j < ary.Length; j++)
                {
                    if (ary[i] == ary[j])
                    {
                        freq[j] = true; //mark as counted
                        cnt++;
                    }

                }
                Console.WriteLine("frequecy of (0) is (1) time:", ary[i], cnt);
            }
        }
    }
}
