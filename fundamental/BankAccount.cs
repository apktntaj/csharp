namespace Classes;

public class BankAccount {
    private static int s_accountRekSeed = 1234567890;
    public string Rek {get;}
    public string Owner {get; set;}
    public decimal Balance {
        get {
            decimal balance = 0;
            foreach (var item in _transactions) {
                balance += item.Amount;
            }

            return balance;
        }
    }


    public BankAccount(string name, decimal initialBalance) {
        Rek = s_accountRekSeed.ToString();
        s_accountRekSeed++;

        Owner = name;
        MakeDeposit(initialBalance, DateTime.Now, "Setoran awal");
    }

    private List<Transaction> _transactions = new List<Transaction>();

    public void MakeDeposit(decimal amount, DateTime d, string note) {
        if (amount <= 0) {
            throw new ArgumentOutOfRangeException(nameof(amount), "Jumlah setoran harus lebih besar dari nol.");
        }

        var deposit = new Transaction(amount, d, note);
        _transactions.Add(deposit);
    }
       
    public void MakeWithdrawal(decimal amount, DateTime d, string note) {
        if (amount <= 0) {
            throw new ArgumentOutOfRangeException(nameof(amount), "Jumlah penarikan harus lebih besar dari nol.");
        }

        if (Balance - amount < 0) {
            throw new InvalidOperationException("Saldo tidak cukup untuk melakukan penarikan.");
        }

        var withdrawal = new Transaction(-amount, d, note);
        _transactions.Add(withdrawal);
    }
}
