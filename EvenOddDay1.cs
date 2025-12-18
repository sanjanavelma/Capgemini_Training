using System;
class EO
{
    public static void EvenOdd()
    {
        Console.WriteLine("Enter a number:");
        int Num = Convert.ToInt32(Console.ReadLine());

        if (Num % 2 == 0)
        {
            Console.WriteLine("The number is even.");
        }
        else
        {
            Console.WriteLine("The number is odd.");
        }
        }

    }
