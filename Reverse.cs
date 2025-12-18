using System;
class Re
{
    public static void Reverse()
    {
        int e = 0;
        int r = 0;
        Console.WriteLine("Enter num: ");
        int a = Convert.ToInt32(Console.ReadLine());
        while (a > 0)
        {
            e = a%10;
            r = r*10+e;
            a /= 10;
        }
        Console.WriteLine(r);
    }
}