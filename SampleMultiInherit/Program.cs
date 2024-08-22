namespace SampleMultiInherit
{
    interface IEmployee
    {
        void BasicDetails();
       
        void SalaryDetails();
    }
    interface IPEmpl
    {
        void AttendMeetings();
    }
    class PermanentEmployee : IEmployee,IPEmpl //Multiple Inheritance implementation
    {
        public int Empid { get; set; }
        public string? Name { get; set; }
        public decimal Salary { get; set; }

        public void AttendMeetings()
        {
            Console.WriteLine("Attend Meetings");
        }

        public void BasicDetails()
        {
            Console.WriteLine(Empid+" " + Name);
        }

        public void SalaryDetails()
        {
            Console.WriteLine("PermanentEmployee:" + Salary);
        }
    }
    class TemporaryEmployee : IEmployee
    {
        public int Empid { get; set; }
        public string? Name { get; set; }
        public decimal Salaryperday { get; set; }

        public void BasicDetails()
        {
            Console.WriteLine(Empid+ " " + Name);
        }

        public void SalaryDetails()
        {
            Console.WriteLine("TemporaryEmployee" + Salaryperday);
        }
    }
    internal class Program
    {
        private static void Main(string[] args)
        {
           Console.WriteLine("Enter type of Employee:1.Permanent 2.Temporary");
            string? typemp = Console.ReadLine();
            if (typemp.ToLower().Equals("permanent"))
            {
                IEmployee pemp = new PermanentEmployee() { Empid=111,Name="Liya",Salary=80000};
                pemp.BasicDetails();
                pemp.SalaryDetails();
                IPEmpl pml = new PermanentEmployee();
                pml.AttendMeetings();

            }
            else if(typemp.ToLower().Equals("temporary"))
            {
                TemporaryEmployee temp = new TemporaryEmployee() { Empid =222, Name = "Riya", Salaryperday = 8000 };
                temp.BasicDetails();
                temp.SalaryDetails();
            }
            //Nullables
           // string? nm = null;
            int? a = null;
            int? b = a ?? 10; //Null coleascing operator
            int c = b ?? 5;
            Console.WriteLine("a:"+a+" :"+"b:"+b+" C:"+c);
        }
    }
}
