﻿class OperatorOverlaoding
{
     static void Main(string[] args)
    {
        BankAccount bank1 = new BankAccount(50,"Bob");
        BankAccount bank2 = new BankAccount(150, "Fred");

        BankAccount bank3 = bank1 + bank2;

    }
}
