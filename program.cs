Console.WriteLine("hello to the Bank");

BankAccount account = new BankAccount(1100);

// account.balance = 100;
   try{
    account.makeDeposit(-1);
   } catch(Exception ex) {
    Console.WriteLine(ex.Message);
   }

Console.Write($" Your account balance is: {account.getBalance()}");
Console.WriteLine($" AccountNumber: {account.accountNumber}");