using System;
class LOTN
{
    public static void LargestOfThreeNumbers()
    {
        Console.WriteLine("Enter 1st num: ");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter 2nd num: ");
        int b = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter 3rd num: ");
        int c = Convert.ToInt32(Console.ReadLine());
        if (a < b && b > c)
        {
            Console.WriteLine("B is largest");
        }
        else if(a < c)
        {
            Console.WriteLine("C is largest");
        }
        else
        {
            Console.WriteLine("A is largest");
        }
    }
}