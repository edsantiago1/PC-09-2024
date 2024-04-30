using Classes;

var account = new BankAccount("Esdras Santiago", 1000);
Console.WriteLine($"Account {account.Number} was created for {account.Owner} with {account.Balance} balance.");

account.MakeWithdrawal(500, DateTime.Now, "Rent payment");
Console.WriteLine(account.Balance);
account.MakeDeposit(100, DateTime.Now, "friend paid me back");
Console.WriteLine(account.Balance);

Console.WriteLine(account.GetAccountHistory());

// Test that the initial balances must be positive:
try
{
    var invalidAccount = new BankAccount("invalid", -1500);
}
catch (ArgumentOutOfRangeException e)
{
    Console.WriteLine("Excepcion saldo inicial de cuenta negativo");
    Console.WriteLine(e.ToString());
}

// Test for a negative balance
try
{
    account.MakeWithdrawal(2000, DateTime.Now, "Intento de retiro");
}
catch (InvalidOperationException e)
{
    Console.WriteLine("Excepcion en el retiro");
    Console.WriteLine(e.ToString());
}
try
{
    account.MakeDeposit(-750, DateTime.Now, "Deposito negativo");
}
catch (ArgumentOutOfRangeException e)
{
    Console.WriteLine("Excepcion los depositos no pueden ser negativos");
    Console.WriteLine(e.ToString());
}
try{
    account.MakeWithdrawal(0, DateTime.Now,"Pago erroneo");
}
catch(ArgumentOutOfRangeException e){
    Console.WriteLine("Excepcion los depositos tampooco pueden ser 0");
    Console.WriteLine(e.ToString());
}