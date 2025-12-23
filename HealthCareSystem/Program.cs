class Program
{
    static void Main()
    {
        string h=HospitalSystem.HospitalName;
        Console.Write("Enter Patient ID: ");
        int pid=Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter Patient Name: ");
        string pname=Console.ReadLine();
        Console.Write("Enter Patient Age: ");
        string ageInput=Console.ReadLine();
        InputValidator validator=new InputValidator();
        int age=validator.ReadAge(ageInput);
        Patient patient=new Patient(pid,pname,age);
        Console.Write("Enter Medical History: ");
        string history=Console.ReadLine();
        patient.SetMedicalHistory(history);
        Console.Write("Enter Doctor Name: ");
        string dname=Console.ReadLine();
        Doctor doctor=new Doctor(dname,"General Physician",123456);
        AppointmentScheduler scheduler=new AppointmentScheduler();
        scheduler.ScheduleAppointment(patient,doctor,DateTime.Now.AddDays(1),"Online");
        DiagnosisService diagnosis=new DiagnosisService();
        string condition="Normal";
        string risk;
        diagnosis.EvaluatePatient(in age,ref condition,out risk,80,65,70);
        Console.WriteLine("Condition: "+condition);
        Console.WriteLine("Risk Level: "+risk);
        BillingService bill=new BillingService{ConsultationFee=500,TestCharges=2500,RoomCharges=3000};
        double total=bill.CalculateBill();
        Console.WriteLine("Total Bill: "+total);
        InsuranceService insurance=new InsuranceService();
        double final=insurance.ApplyInsurance(30,total);
        Console.WriteLine("Final Payable After Insurance: "+final);
    }
}
