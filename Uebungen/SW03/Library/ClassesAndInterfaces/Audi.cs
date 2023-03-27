namespace ClassesAndInterfaces;

abstract class Audi : IAutomobil
{
    private int verzogerungProSekunde = 5;
    public Geschwindigkeit Geschwindigkeit { get; private set; }
    public int AnzahlRaeder { get; }

    public abstract Geschwindigkeit Beschleunigen(int anzahlSekunden);

    public Geschwindigkeit Bremsen(int anzahlSekunden)
    {
        this.Geschwindigkeit = new Geschwindigkeit(Geschwindigkeit.Value - anzahlSekunden * verzogerungProSekunde);
        return this.Geschwindigkeit;
    }
}