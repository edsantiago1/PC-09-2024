using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;

namespace Classes;

public class BankAccount
{
    public decimal initialBalance { get; set; }
    public string Number { get; set;}
    public string Owner { get; set; }
    public string Type { get; set;}

#region BalanceComputation
    public decimal Balance
    {
        get
        {
            decimal balance = 0;
            foreach (var item in _allTransactions)
            {
                balance += item.Amount;
            }

            return balance;
        }
    }
#endregion

    private static int s_accountNumberSeed = 1234567890;
#region Constructor
    public BankAccount(decimal number, string name, decimal initialBalance, string type)
    {
        Number = number.ToString(); 

        Owner = name;
        MakeDeposit(initialBalance, DateTime.Now, "Initial balance");

        Type = type;
    }
#endregion

#region TransactionDeclaration
    private List<Transaction> _allTransactions = new List<Transaction>();
#endregion

#region DepositAndWithdrawal
    public void MakeDeposit(decimal amount, DateTime date, string note)
    {
        if (amount <= 0)
        {
            throw new ArgumentOutOfRangeException(nameof(amount), "Amount of deposit must be positive");
        }
        var deposit = new Transaction(amount, date, note);
        _allTransactions.Add(deposit);
    }

    public void MakeWithdrawal(decimal amount, DateTime date, string note)
    {
        if (amount <= 0)
        {
            throw new ArgumentOutOfRangeException(nameof(amount), "Amount of withdrawal must be positive");
        }
        if (Balance - amount < 0)
        {
            throw new InvalidOperationException("Not sufficient funds for this withdrawal");
        }
        var withdrawal = new Transaction(-amount, date, note);
        _allTransactions.Add(withdrawal);
    }
#endregion

#region History
    public string GetAccountHistory()
    {
        var report = new System.Text.StringBuilder();

        decimal balance = 0;
        report.AppendLine("Date\t\tAmount\tBalance\tNote");
        foreach (var item in _allTransactions)
        {
            balance += item.Amount;
            report.AppendLine($"{item.Date.ToShortDateString()}\t{item.Amount}\t{balance}\t{item.Notes}");
        }

        return report.ToString();
    }
#endregion

#region stringArray
    public void dataString(string name, string accounNumber, string accountType, decimal balance ){
        string[] userData = new string[4];
        userData[0] = name;
        userData[1] = accounNumber;
        userData[2] = accountType;
        userData[3] = balance.ToString("f2");
        foreach(var item in userData){
            Console.WriteLine(item.ToString());
        }
    }
#endregion
}