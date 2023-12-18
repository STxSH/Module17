namespace Module17
{
    public class RegularAccount : IAccount
    {
        public double Balance { get; }

        public double Interest { get; set; }

        public RegularAccount(double balance)
        {
            this.Balance = balance;
        }

        public double CalculateInterest()
        {
            double interest = Balance * 0.4;

            if (Balance < 1000)
                interest -= Balance * 0.2;
            else if (Balance >= 1000)
                interest -= Balance * 0.4;

            return interest;
        }
    }
}
