
public class InsufficientBalanceException : Exception
{
    public InsufficientBalanceException()
        : base("Solde insuffisant.")
    {
    }
}