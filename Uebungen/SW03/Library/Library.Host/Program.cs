// See https://aka.ms/new-console-template for more information

using Library.Host;

Console.WriteLine("Hello, World!");

Bibliothek bibliothek = new Bibliothek();
bibliothek.BuchHinzufuegen(new Buch("1984", "George Orwell", new DateTime(1949, 6, 1)));
bibliothek.BuchHinzufuegen(new Buch("Harry Potter und der Stein der Weisen", "J.K. Rowling", new DateTime(1997, 6, 26)));

bibliothek.VorhandeneBuecher();