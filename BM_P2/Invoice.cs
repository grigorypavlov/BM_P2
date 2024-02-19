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
    public decimal AmountOpen { get; set; }
    
    public InvoiceState AddPaymentToInvoice(Invoice invoice, Payment payment)
    {
        invoice.AmountOpen -= payment.Betrag;
        if (invoice.AmountOpen > 0)
        {
            return InvoiceState.PartiallyPaid;
        }

        if (invoice.AmountOpen == 0)
        {
            return InvoiceState.Paid;
        }

        return InvoiceState.OverPaid;
    }
}