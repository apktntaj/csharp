namespace Classes;

public class Transaction
{
    public decimal Amount {get;}
    public DateTime Date {get;}
    public string Notes {get;}

    public Transaction(decimal amount, DateTime d, string note) {
        Amount = amount;
        Date = d;
        Notes = note; 
    }
}
