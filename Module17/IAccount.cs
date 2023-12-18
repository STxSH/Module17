namespace Module17
{
    public interface IAccount
    {
        double Balance { get; }
        double Interest { get; set; }

        public double CalculateInterest();
    }
}
