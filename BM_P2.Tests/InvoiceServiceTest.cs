using FluentAssertions;

namespace BM_P2;

// TODO: umbenennen in InvoiceTest und anpassen der Testfälle, damit nun der korrekte Konstruktor von Invoice verwendet
// wird und die verschobene Methode auf der Invoice aufgerufen wird.
public class InvoiceServiceTest
{
    [Fact]
    public void InvoiceShouldBePaidPartiallyWhenAmountOfPaymentSmallerThanAmountOpen()
    {
        var invoice = new Invoice();
        invoice.Amount = 10m;
        invoice.AmountOpen = 10m;
        var payment = new Payment();
        payment.Betrag = 5m;
        var sut = new InvoiceService();
        
        var state = sut.AddPaymentToInvoice(invoice, payment);

        state.Should().Be(InvoiceState.PartiallyPaid);
        invoice.Amount.Should().Be(10m);
        invoice.AmountOpen.Should().Be(5m);
    }
    
    [Fact]
    public void InvoiceShouldBePaidWhenAmountOfPaymentEqualToAmountOpen()
    {
        var invoice = new Invoice();
        invoice.Amount = 10m;
        invoice.AmountOpen = 10m;
        var payment = new Payment();
        payment.Betrag = 10m;
        var sut = new InvoiceService();
        
        var state = sut.AddPaymentToInvoice(invoice, payment);

        state.Should().Be(InvoiceState.Paid);
        invoice.Amount.Should().Be(10m);
        invoice.AmountOpen.Should().Be(0m);
    }
    
    [Fact]
    public void InvoiceShouldBeOverPaidWhenAmountOfPaymentGreaterThanAmountOpen()
    {
        var invoice = new Invoice();
        invoice.AmountOpen = 10m;
        invoice.Amount = 10m;
        var payment = new Payment();
        payment.Betrag = 11m;
        var sut = new InvoiceService();
        
        var state = sut.AddPaymentToInvoice(invoice, payment);

        state.Should().Be(InvoiceState.OverPaid);
        invoice.Amount.Should().Be(10m);
        invoice.AmountOpen.Should().Be(-1m);
    }
}