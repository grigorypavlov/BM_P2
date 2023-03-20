namespace Buchhaltung;

public class Zahlung
{
    public Zahlung(decimal betrag)
    {
        Betrag = betrag;
    }

    public decimal Betrag { get; }
}