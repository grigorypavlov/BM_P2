// See https://aka.ms/new-console-template for more information


using Buchhaltung;

var rechnung = new Rechnung();
rechnung.BetragOffen = 10m;

Zahlung zahlung = new Zahlung();
zahlung.Betrag = 5m;

var rechnungService = new RechnungService();
var state = rechnungService.AddZahlungToRechnung(rechnung, zahlung);

Console.WriteLine($"Betrag offen: {rechnung.BetragOffen}, state = {state}");