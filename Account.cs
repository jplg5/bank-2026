public abstract class Account
{
    
    public string Number { get; set; }
    public double Balance { get; private set; } 
    public Person Owner{ get; set; }

    public Account(string number, double balance, Person owner)
    {
        Number = number;
        Balance = balance;
        Owner = owner;
    }

    public virtual void Deposit(double amount)
    {
        if (amount <= 0)
        {
            throw new ArgumentOutOfRangeException("Doit etre superieur a 0");
        }
        Balance += amount;
    }

    public virtual void Withdraw(double amount)
    {

        if (amount <= 0)
        {
            throw new ArgumentOutOfRangeException(
                nameof(amount),
                "Le montant doit être supérieur à 0.");
        }

        if (Balance < amount)
        {
            throw new InsufficientExecutionStackException(
                "Solde insuffisant pour effectuer le retrait.");
        }
        Balance -= amount;
    }

    public void ApplyInterest()
    {
        Balance += CalculInterets();
    }

    protected abstract double CalculInterets();

}