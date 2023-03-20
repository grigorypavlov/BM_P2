// See https://aka.ms/new-console-template for more information


using Buchhaltung;

var rechnung = new Rechnung(10m);
var zahlung = new Zahlung(5m);

rechnung.Add(zahlung);

Console.WriteLine($"Betrag offen: {rechnung.BetragOffen}, state = {rechnung.State}");
