namespace ClassesAndInterfaces;

public class BMW : IAutomobil
{
    private int beschleunigungProSekunde = 3;
    public Geschwindigkeit Geschwindigkeit { get; private set; }
    public int AnzahlRaeder { get; }

    public Geschwindigkeit Beschleunigen(int anzahlSekunden)
    {
        this.Geschwindigkeit = new Geschwindigkeit(Geschwindigkeit.Value + anzahlSekunden * beschleunigungProSekunde);
        return this.Geschwindigkeit;
    }

    public Geschwindigkeit Bremsen(int anzahlSekunden)
    {
        this.Geschwindigkeit = new Geschwindigkeit(Geschwindigkeit.Value - anzahlSekunden * beschleunigungProSekunde);
        return this.Geschwindigkeit;
    }
}