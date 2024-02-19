namespace BM_P2;

public class InvoiceService
{
    // TODO: verschieben dieser Methode in die Klasse Invoice, um die Kohäsion zu erhöhen.
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