public class CurrentAccount : Account
{
    
    
    public double CreditLine { get; set; }

    public CurrentAccount(string Number,double Balance,double CreditLine,Person Owner)
    
        : base(Number, Balance, Owner)
    {
        if (CreditLine <= 0)
        {
            throw new ArgumentOutOfRangeException();
        }
        this.CreditLine = CreditLine;
    }

    protected override double CalculInterets()
    {
        if (Balance >= 0)
        {
            return Balance * 0.03;
        }

        return Balance * 0.0975;
    }
   
}