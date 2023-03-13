namespace BM_P2_Class_vs_objects;

public class Auto
{
    private readonly int beschleunigungsschritt;

    // Eigenschaften
    public string Marke { get; set; }
    public string Modell { get; set; }
    public string Farbe { get; set; }
    
    public int AktuelleGeschwindigkeit { get; set; }

    // Konstruktor
    public Auto(string marke, string modell, string farbe, int beschleunigungsschritt)
    {
        Marke = marke;
        Modell = modell;
        Farbe = farbe;
        this.beschleunigungsschritt = beschleunigungsschritt;
    }

    public Auto()
    {
        this.beschleunigungsschritt = 10;
    }

    // Methoden
    public void Beschleunigen()
    {
        Console.WriteLine("Das Auto beschleunigt!");
    }

    public void Bremsen()
    {
        Console.WriteLine("Das Auto bremst!");
    }

    public void Parken()
    {
        Console.WriteLine("Das Auto parkt!");
    }
}
