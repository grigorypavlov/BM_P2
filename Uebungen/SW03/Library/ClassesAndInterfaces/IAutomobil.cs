namespace ClassesAndInterfaces;

public interface IAutomobil
{
    Geschwindigkeit Geschwindigkeit { get; }
    int AnzahlRaeder { get; }

    Geschwindigkeit Beschleunigen(int anzahlSekunden);
    Geschwindigkeit Bremsen(int anzahlSekunden);
}