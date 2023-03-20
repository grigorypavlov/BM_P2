namespace Buchhaltung;

public class RechnungService
{
    public RechnungState AddZahlungToRechnung(Rechnung rechnung, Zahlung zahlung)
    {
        rechnung.BetragOffen -= zahlung.Betrag;
        if (rechnung.BetragOffen > 0)
        {
            return RechnungState.Teilbezahlt;
        }

        if (rechnung.BetragOffen == 0)
        {
            return RechnungState.Bezahlt;
        }

        return RechnungState.Ueberbezahlt;
    }
}