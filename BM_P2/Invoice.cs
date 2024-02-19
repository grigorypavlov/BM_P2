namespace BM_P2;

public class Invoice
{
    public Invoice(decimal amount)
    {
        Amount = amount;
        AmountOpen = amount;
    }
    
    // TODO: Properties sollten Readonly sein.
    public decimal Amount { get; }
    public decimal AmountOpen { get; private set; }
    
    public InvoiceState Pay(Payment payment)
    {
        this.AmountOpen -= payment.Betrag;
        if (this.AmountOpen > 0)
        {
            return InvoiceState.PartiallyPaid;
        }

        if (this.AmountOpen == 0)
        {
            return InvoiceState.Paid;
        }

        return InvoiceState.OverPaid;
    }
}