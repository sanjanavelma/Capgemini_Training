using System;

class FTC

{
    public static void FeetToCenti()
    {
        Console.WriteLine("Enter feet:");
        double feet = Convert.ToDouble(Console.ReadLine());
        double centi = feet * 30.48;
        Console.WriteLine("Centimeters:" + centi);
        }
}
