﻿// See https://aka.ms/new-console-template for more information

using BM_P2;

var invoice = new Invoice(10m);

var payment = new Payment(betrag: 5m);

var rechnungService = new InvoiceService();
var state = invoice.AddPaymentToInvoice(invoice, payment);