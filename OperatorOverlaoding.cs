class OperatorOverlaoding
{
     static void Main(string[] args)
    {
        //shorthand for providing a new definition of an operator
        BankAccount bank1 = new BankAccount(50,"Bob");
        BankAccount bank2 = new BankAccount(150, "Fred");

        BankAccount bank3 = bank1 + bank2;
        Console.WriteLine(bank3.Owner);
        Console.WriteLine(bank3.Money);

        BankAccount bank4 = bank3 +500;

         Console.WriteLine(bank4.Owner);
        Console.WriteLine(bank4.Money);


    }
}
