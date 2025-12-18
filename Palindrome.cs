using System;
class Pd
{
    public static void Palindrome()
    {
        Console.WriteLine("Enter string: ");
        string s = Console.ReadLine();
        int beg = 0;
        int end = s.Length-1;
        bool isPalindrom = true;
        while (beg < end)
        {
            if (s[beg] != s[end])
            {
                isPalindrom = false;
                break;
            }
            beg ++;
            end--;
        }
        if (isPalindrom)
        {
            Console.WriteLine("String is Palindrom");
        }
        else
        {
            Console.WriteLine("String is not Plaindrom");
        }
    }
}