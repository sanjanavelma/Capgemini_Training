using System;
using System.Collections;
class Program
{
    static void Main()
    {
        LibraryManager l = new LibraryManager();
        int n = int.Parse(Console.ReadLine());
        for(int i = 0; i < n; i++)
        {
            string[] input = Console.ReadLine().Split();
            if(input[0] == "ADD")
            {
                l.addMember(input[1]);
            }
            else if(input[0] == "IMPOSE")
            {
                long amount = long.Parse(input[2]);
                l.imposeFine(input[1], amount);
            }
            else if(input[0] == "PAY")
            {
                long amount1 = long.Parse(input[2]);
                l.payFine(input[1], amount1);
            }
            else if (input[0] == "DETAILS")
            {
                Console.WriteLine(l.getDetails(input[1]));
            }
        }
    }
}