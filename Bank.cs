public class Bank
{
    
    public Dictionary<string, Account> Accounts { get; set; }
    public string Name;


    public Bank(String Name)
    {
        this.Name=Name;
        Accounts = new Dictionary<string, Account>();

    }

    public void AddAccount(Account account)
    {
        Accounts.Add(account.Number,account);

    }
    public void DeleteAccount(string number)
    {
        
        Accounts.Remove(number);
    }

    public double ReturnBalance(string number)
    {
        return Accounts[number].Balance;
    }

    public double ReturnallAccountBalance(Person person)
    {

        double somme=0;

        foreach (Account account in Accounts.Values)
        {
            if (account.Owner==person)
            {
                somme+= account.Balance;
            }
        }
        return somme;
    }



}