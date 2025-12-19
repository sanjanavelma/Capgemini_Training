using System;
class Debit
{
        public void ATMWithDrawalLimit()
    {
        Console.WriteLine("Enter Withdrawal amount: ");
        double withdraw = Convert.ToDouble(Console.ReadLine());
        if (withdraw <= 400000)
        {
            Console.WriteLine("Withdrawal permitted within daily limit.");
        }
        else
        {
            Console.WriteLine("Daily ATM withdrawal limit exceeded.");
        }
    }
    public void EMIBurdenEvalution()
    {
        Console.WriteLine("Enter monthly income: ");
        Double MI = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter EMI amount: ");
        Double EMI = Convert.ToDouble(Console.ReadLine());
        Double correct = MI * 0.40;
        if (EMI <= correct)
        {
            Console.WriteLine("EMI is financially manageable");
        }
        else
        {
            Console.WriteLine("EMI exceeds safe income limit.");
        }
    }

    public void DailySpending()
    {
        Console.Write("Enter number of debit transactions today: ");
        int n = Convert.ToInt32(Console.ReadLine());
        double total = 0;
        for (int i = 1; i <= n; i++)
        {
            Console.Write($"Enter transaction {i} amount: ");
            double t = Convert.ToDouble(Console.ReadLine());
            total += t;
        }
        Console.WriteLine($"Total debit amount for the day: {total}\n");
    }

    public void MinBalanceCheck()
    {
        Console.Write("Enter current account balance: ");
        double balance = Convert.ToDouble(Console.ReadLine());
        if (balance < 2000)
            Console.WriteLine("Minimum balance not maintained. Penalty applicable.\n");
        else
            Console.WriteLine("Minimum balance requirement satisfied.\n");
    }
}

class Credit
{

    public void NetSalary()
    {
        Console.Write("Enter gross salary: ");
        double salary = Convert.ToDouble(Console.ReadLine());
        double deduction = salary * 0.10;
        double net = salary - deduction;
        Console.WriteLine($"Net salary credited: {net}\n");
    }

    public void FixedDeposit()
    {
        Console.Write("Enter Principal Amount: ");
        double p = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter Rate of Interest (%): ");
        double r = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter Time Period (in years): ");
        double t = Convert.ToDouble(Console.ReadLine());
        double interest = (p * r * t) / 100;
        double maturity = p + interest;
        Console.WriteLine($"Fixed Deposit maturity amount: {maturity}\n");
    }

    public void RewardPoints()
    {
        Console.Write("Enter total credit card spending: ");
        double spend = Convert.ToDouble(Console.ReadLine());
        int points = (int)(spend / 100);
        Console.WriteLine($"Reward points earned: {points}\n");
    }

    public void BonusEligibility()
    {
        Console.Write("Enter annual salary: ");
        double salary = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter years of service: ");
        int years = Convert.ToInt32(Console.ReadLine());
        if (salary >= 500000 && years >= 3)
            Console.WriteLine("Employee is eligible for bonus.\n");
        else
            Console.WriteLine("Employee is not eligible for bonus.\n");
    }
}

class Banking
{
    public static void FinanceBankingSystem()
    {
        Debit d = new Debit();
        Credit c = new Credit();
        int val;
        do
        {
            Console.WriteLine("1. Debit\n2. Credit \n3. Exit");
            Console.WriteLine("Enter Your Choice(1/2/3)..:");
            val = Convert.ToInt32(Console.ReadLine());
            switch (val)
            {
                case 1:
                    DebitMenu(d);
                    break;
                case 2:
                    CreditMenu(c);
                    break;
                case 3:
                    Console.WriteLine("Thank you!");
                    break;
                default:
                    Console.WriteLine("Invalid choice!");
                    break;
            }

        } while (val != 3);
    }

    static void DebitMenu(Debit d)
    {
        int option;
        do
        {
            Console.WriteLine("1. ATM Withdrawal Limit Check");
            Console.WriteLine("2. EMI Evaluation");
            Console.WriteLine("3. Daily Spending Calculator");
            Console.WriteLine("4. Minimum Balance Check");
            Console.WriteLine("5. Back to Main Menu");
            Console.Write("Enter your choice: ");
            option = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            switch (option)
            {
                case 1:
                    d.ATMWithDrawalLimit();
                    break;
                case 2:
                    d.EMIBurdenEvalution();
                    break;
                case 3:
                    d.DailySpending();
                    break;
                case 4:
                    d.MinBalanceCheck();
                    break;
                case 5:
                    Console.WriteLine("Returning to main menu...\n");
                    break;
                default:
                    Console.WriteLine("Invalid Option!\n");
                    break;
            }

        } while (option != 5);
    }
    static void CreditMenu(Credit c)
    {
        int option;
        do
        {
            Console.WriteLine("----- Credit Operations -----");
            Console.WriteLine("1. Net Salary Credit");
            Console.WriteLine("2. Fixed Deposit Maturity");
            Console.WriteLine("3. Reward Points Calculation");
            Console.WriteLine("4. Bonus Eligibility Check");
            Console.WriteLine("5. Back to Main Menu");
            Console.Write("Enter your choice: ");
            option = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            switch (option)
            {
                case 1:
                    c.NetSalary();
                    break;
                case 2:
                    c.FixedDeposit();
                    break;
                case 3:
                    c.RewardPoints();
                    break;
                case 4:
                    c.BonusEligibility();
                    break;
                case 5:
                    Console.WriteLine("Returning to main menu...\n");
                    break;
                default:
                    Console.WriteLine("Invalid Option!\n");
                    break;
            }
        } while (option != 5);
    }
}
