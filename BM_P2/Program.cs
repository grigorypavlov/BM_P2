// See https://aka.ms/new-console-template for more information

using BM_P2;

var invoice = new Invoice(10m);

var payment = new Payment();
payment.Betrag = 5m;

var rechnungService = new InvoiceService();
var state = rechnungService.AddPaymentToInvoice(invoice, payment);