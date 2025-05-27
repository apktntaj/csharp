using Classes;

var account = new BankAccount("John Doe", 1000.00m);
Console.WriteLine($"Akun berhasil dibuat dengan nama {account.Owner} ({account.Rek}) dan saldo awal {account.Balance}");

account.MakeWithdrawal(500, DateTime.Now, "Rent payment");
Console.WriteLine(account.Balance);
account.MakeDeposit(100, DateTime.Now, "Friend paid me back");
Console.WriteLine(account.Balance);