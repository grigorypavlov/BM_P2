// TODO: Auskommentieren, wenn Aufgabe 1 + 2 bearbeitet
// using FluentAssertions;

// namespace Pruefung.Tests;
//
// public class BankTests
// {
//     [Test]
//     public void BankWirdErstellt()
//     {
//         var bank = new Bank("NAB");
//
//         bank.Name.Should().Be("NAB");
//     }
//
//     [Test]
//     public void SignaturBerechtigterKannUeberweisungTaetigen()
//     {
//         var bank = new Bank("NAB");
//
//         var angestellte = new List<NatuerlichePerson>();
//         var signaturberechtigter = new NatuerlichePerson("Muster", "Max", new DateTime(2002, 7, 23));
//         angestellte.Add(signaturberechtigter);
//         var sender = bank.Create(new Firma("ABC AG", angestellte), 70m);
//         sender.SetzeSignaturberechtigten(signaturberechtigter);
//
//         var privatKontoBesitzer = new List<Person>();
//         privatKontoBesitzer.Add(new NatuerlichePerson("Silver", "John", new DateTime(1950, 8, 12)));
//         var empfaenger = bank.Create(privatKontoBesitzer, 30m);
//
//         bank.Ueberweise(sender, signaturberechtigter, empfaenger, 50m);
//
//         sender.Guthaben.Should().Be(20m);
//         empfaenger.Guthaben.Should().Be(80m);
//     }
//
//     [Test]
//     public void NichtSignaturBerechtigterKannKeineUeberweisungTaetigen()
//     {
//         var bank = new Bank("NAB");
//
//         var angestellte = new List<NatuerlichePerson>();
//         var signaturberechtigter = new NatuerlichePerson("Muster", "Max", new DateTime(2002, 7, 23));
//         var nichtSignaturberechtigter = new NatuerlichePerson("Heiri", "Hans", new DateTime(2002, 7, 23));
//         angestellte.Add(signaturberechtigter);
//         var sender = bank.Create(new Firma("ABC AG", angestellte), 70m);
//         sender.SetzeSignaturberechtigten(signaturberechtigter);
//
//         var privatKontoBesitzer = new List<Person>();
//         privatKontoBesitzer.Add(new NatuerlichePerson("Silver", "John", new DateTime(1950, 8, 12)));
//         var empfaenger = bank.Create(privatKontoBesitzer, 30m);
//
//         Action act = () => bank.Ueberweise(sender, nichtSignaturberechtigter, empfaenger, 50m);
//
//         act.Should().Throw<ArgumentException>();
//
//         sender.Guthaben.Should().Be(70m);
//         empfaenger.Guthaben.Should().Be(30m);
//     }
// }