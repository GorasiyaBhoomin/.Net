using System;

class AdmissionEligibility
{
    static void Main(string[] args)
    {
        Console.Write("Input the marks obtained in Maths : ");
        int maths = Convert.ToInt32(Console.ReadLine());

        Console.Write("Input the marks obtained in Physics : ");
        int physics = Convert.ToInt32(Console.ReadLine());

        Console.Write("Input the marks obtained in Chemistry : ");
        int chemistry = Convert.ToInt32(Console.ReadLine());

        int total = maths + physics + chemistry;
        int totalMP = maths + physics;

        if (maths >= 65 && physics >= 55 && chemistry >= 50 &&
            (total >= 180 || totalMP >= 140))
        {
            Console.WriteLine("The candidate is eligible for admission.");
        }
        else
        {
            Console.WriteLine("The candidate is not eligible for admission.");
        }

        Console.ReadLine();
    }
}
