namespace BM_P2;

public static class InvoiceExtensions
{
    public static void Pay(this Invoice invoice, decimal paymentAmount)
    {
        invoice.AmountOpen -= paymentAmount;
        invoice.AmountPaid += paymentAmount;
    }
}