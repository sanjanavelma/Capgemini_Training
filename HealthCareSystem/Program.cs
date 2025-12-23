using System;

namespace HealthCareSystem
{
    class Program
    {
        static void Main()
        {
            string sys = HospitalSystem.HospitalName;

            bool run = true;
            while (run)
            {
                Console.Clear();
                Console.WriteLine("========== IHCMS HOSPITAL SYSTEM ==========");
                Console.WriteLine("1. Patient Management");
                Console.WriteLine("2. Doctor Management");
                Console.WriteLine("3. Appointment Management");
                Console.WriteLine("4. Diagnosis Service");
                Console.WriteLine("5. Billing System");
                Console.WriteLine("6. Insurance System");
                Console.WriteLine("7. Stay Calculator (Recursion)");
                Console.WriteLine("8. Exit");
                Console.WriteLine("===========================================");
                Console.Write("Enter Choice: ");

                switch (Console.ReadLine())
                {
                    case "1":
                        PatientModule.PatientMenu();
                        break;

                    case "2":
                        DoctorModule.DoctorMenu();
                        break;

                    case "3":
                        AppointmentModule.AppointmentMenu();
                        break;

                    case "4":
                        RunDiagnosis();
                        break;

                    case "5":
                        RunBilling();
                        break;

                    case "6":
                        RunInsurance();
                        break;

                    case "7":
                        RunStayCalc();
                        break;

                    case "8":
                        run = false;
                        break;

                    default:
                        Console.WriteLine("Invalid Option");
                        Console.ReadKey();
                        break;
                }
            }

            Console.WriteLine("System shutting down...");
        }

        static void RunDiagnosis()
        {
            Console.Clear();
            DiagnosisService d = new DiagnosisService();
            Console.Write("Enter Age: ");
            int age = Convert.ToInt32(Console.ReadLine());
            string condition = "Normal";
            string risk;
            d.Evaluate(in age, ref condition, out risk, 80, 90, 100);
            Console.WriteLine("Condition: " + condition);
            Console.WriteLine("Risk Level: " + risk);
            d.PrintDiagnosisReport();
            Console.ReadKey();
        }

        static void RunBilling()
        {
            Console.Clear();
            Billing bill = new Billing
            {
                ConsultationFee = 500,
                TestCharges = 2500,
                RoomCharges = 3000,
                Discount = 10,
                TaxPercent = 5
            };
            bill.PrintBill();
            Console.ReadKey();
        }

        static void RunInsurance()
        {
            Console.Clear();
            InsuranceService ins = new InsuranceService();
            Console.Write("Enter Bill Amount: ");
            double amount = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter Coverage %: ");
            int c = Convert.ToInt32(Console.ReadLine());
            ins.PrintInsuranceSummary(amount, c);
            Console.ReadKey();
        }

        static void RunStayCalc()
        {
            Console.Clear();
            StayCalculator s = new StayCalculator();
            Console.Write("Enter Stay Days: ");
            int d = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Calculated Stay Days: " + s.CalculateStayDays(d));
            Console.ReadKey();
        }
    }
}
