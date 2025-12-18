using System;

class Li
{
    public static void License()
    {
        Console.WriteLine("Enter age: ");
        int age = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("true/false: ");
        bool hasLicense = Convert.ToBoolean(Console.ReadLine());
        if (age >= 18)
        {
            if (hasLicense)
            {
                Console.WriteLine("You are allowed to drive");
            }
            else
            {
                Console.WriteLine("License reqired");
            }
        }
    }
}