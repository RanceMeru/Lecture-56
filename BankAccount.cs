class BankAccount
{
    private double money;
    private string owner;


    public BankAccount(double money, string owner)
    {
        this.money = money;
        this.owner = owner;
    }
    public double Money
    {
        get
        {
            return money;
        }


    } 

    public string Owner
    {
        get
        {
            return owner;
        }
    }

    public static BankAccount operator + (BankAccount bank1, BankAccount bank2)
    {
        int newAmountOfMoney = bank1.Money + bank2.Money;
        string owner = bank1.Owner + "+" + bank2.Owner;

        BankAccount newBankAccount = new BankAccount(newAmountOfMoney,newOwners);
        return newBankAccount;

    }
}