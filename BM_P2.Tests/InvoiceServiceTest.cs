using FluentAssertions;

namespace BM_P2;

// TODO: umbenennen in InvoiceTest und anpassen der Testfälle, damit nun der korrekte Konstruktor von Invoice verwendet
// wird und die verschobene Methode auf der Invoice aufgerufen wird.
public class InvoiceTest
{
    [Fact]
    public void InvoiceShouldBePaidPartiallyWhenAmountOfPaymentSmallerThanAmountOpen()
    {
        var invoice = new Invoice(amount: 10m);
        var payment = new Payment(betrag: 5m);
        
        var state = invoice.Pay(payment);

        state.Should().Be(InvoiceState.PartiallyPaid);
        invoice.Amount.Should().Be(10m);
        invoice.AmountOpen.Should().Be(5m);
    }
    
    [Fact]
    public void InvoiceShouldBePaidWhenAmountOfPaymentEqualToAmountOpen()
    {
        var invoice = new Invoice(amount: 10m);
        var payment = new Payment(betrag: 10m);
        
        var state = invoice.Pay(payment);

        state.Should().Be(InvoiceState.Paid);
        invoice.Amount.Should().Be(10m);
        invoice.AmountOpen.Should().Be(0m);
    }
    
    [Fact]
    public void InvoiceShouldBeOverPaidWhenAmountOfPaymentGreaterThanAmountOpen()
    {
        var invoice = new Invoice(amount: 10m);
        var payment = new Payment(betrag: 11m);
        
        var state = invoice.Pay(payment);

        state.Should().Be(InvoiceState.OverPaid);
        invoice.Amount.Should().Be(10m);
        invoice.AmountOpen.Should().Be(-1m);
    }
}