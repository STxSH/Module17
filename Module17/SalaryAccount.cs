namespace Module17
{
    public class SalaryAccount : IAccount
    {
        public double Balance { get; }

        public double Interest { get; set; }

        public SalaryAccount(double balance)
        {
            this.Balance = balance;
        }

        public double CalculateInterest()
        {
            return Balance * 0.5;
        }
    }
}
