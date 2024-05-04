using Classes;
        Console.WriteLine("Ingrese a continuacion los datos solicitados.");
        string name = "";
        while(String.IsNullOrEmpty(name)){
            Console.Write("Nombre: "); name = Console.ReadLine()??string.Empty;
        }
        int saldo = 0;
        while(saldo < 500){
            Console.Write("Saldo Inicial (saldo minimo para apertura de cuenta Q.500.00): "); string? saldoS  = Console.ReadLine();
            int.TryParse(saldoS, out saldo);
            }
        int number = 0;
        string numberS = "";
        while(number <= 0){
            Console.Write("Numero de cuenta: "); numberS = Console.ReadLine()??string.Empty;
            int.TryParse(numberS, out number);
        }
            string typeS = "";
        while(true){
            Console.Write("Escriba \"Monetaria\" si su cuenta es monetaria, y \"Ahorro\" si su cuenta es de ahorro: ");
            typeS = Console.ReadLine().ToUpper()??string.Empty;
            Console.WriteLine(typeS);
            if(typeS == "MONETARIA" || typeS == "AHORRO"){
                break;
            }
        }   
    
 var account = new BankAccount(number, name, saldo, typeS);
 bool menu = true;
 while(menu){
    Console.Clear();
    Console.WriteLine("1.Imprimir datos\n2.Salir del programa");
    Console.Write("Ingrese el numero de opcion que desea realizar: "); string intV = Console.ReadLine()??string.Empty;
    int.TryParse(intV, out int i);
    switch(i){
        case 1:
        account.dataString(name,numberS,typeS,account.Balance);
        break;

        case 2:
        menu = false;
        break;

        default:
        Console.WriteLine("Opcion invalida");

        break;
    }
    Console.ReadKey();
 }
/*Console.WriteLine($"Account {account.Number} was created for {account.Owner} with {account.Balance} balance.");

account.MakeWithdrawal(500, DateTime.Now, "Rent payment");
Console.WriteLine(account.Balance);
account.MakeDeposit(100, DateTime.Now, "friend paid me back");
Console.WriteLine(account.Balance);

Console.WriteLine(account.GetAccountHistory());

// Test that the initial balances must be positive:
try
{
    var invalidAccount = new BankAccount(12345678, "invalid", -1500, "Monetaria");
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
} */





