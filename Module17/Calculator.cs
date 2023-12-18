namespace Module17
{
    public static class Calculator
    {
        public static void CalculateInterest(IAccount account)
        {
            account.Interest = account.CalculateInterest();
        }
    }
}
