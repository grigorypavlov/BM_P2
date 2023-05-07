namespace BM_P2_Class_vs_objects;

public class Person
{
    // Eigenschaften
    public string Vorname { get; set; }
    public string Nachname { get; set; }
    public int Alter { get; set; }

    // private Felder
    private string _adresse;
    private string _telefonnummer;

    // Konstruktor
    public Person(string vorname, string nachname, int alter)
    {
        Vorname = vorname;
        Nachname = nachname;
        Alter = alter;
    }

    // Methoden
    public void Vorstellen()
    {
        Console.WriteLine($"Hallo, ich heiße {Vorname} {Nachname} und bin {Alter} Jahre alt.");
    }

    public void KontaktAufnehmen()
    {
        Console.WriteLine($"Sie können mich unter der Telefonnummer {_telefonnummer} erreichen.");
    }

    // private Methode
    private void AdresseSetzen(string adresse)
    {
        _adresse = adresse;
        Console.WriteLine($"Meine Adresse lautet: {_adresse}");
    }
}

