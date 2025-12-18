using System;
class Sp
{
    public static void Swap()
    {
        int e = 0;
        int r = 0;
        Console.WriteLine("Enter num: ");
        int a = Convert.ToInt32(Console.ReadLine());
        while (a > 0)
        {
            e = a%10;
            r += e;
            a /= 10;
        }
        Console.WriteLine(r);

    }
}