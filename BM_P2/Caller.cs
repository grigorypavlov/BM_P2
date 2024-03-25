namespace BM_P2;

public class Caller
{
    public void CallThem()
    {
        var sum = Math.Functions.Add(Math.Constants.PI, Math.Constants.E);

        var invoice = new Invoice
        {
            Amount = 100.0M,
            AmountOpen = 100.0M,
            AmountPaid = 100.0M
        };
        
        invoice.Pay(50);

        var s = new MyCollection(10)[5];
    }

}