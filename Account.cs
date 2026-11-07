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
        Balance += amount;
    }

    public virtual void Withdraw(double amount)
    {
        Balance -= amount;
    }

    public void ApplyInterest()
    {
        Balance += CalculInterets();
    }

    protected abstract double CalculInterets();

}