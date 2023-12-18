namespace Module17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var regularAccount = new RegularAccount(100);
            Calculator.CalculateInterest(regularAccount);
            Console.WriteLine(regularAccount.Interest);

            var salaryAccount = new SalaryAccount(100);
            Calculator.CalculateInterest(salaryAccount);
            Console.WriteLine(salaryAccount.Interest);
        }
    }
}