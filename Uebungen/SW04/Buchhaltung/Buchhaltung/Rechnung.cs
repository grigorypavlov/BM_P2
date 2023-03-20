using System.Net.Sockets;

namespace Buchhaltung;

public class Rechnung
{
    public Rechnung(decimal betragOffen)
    {
        BetragOffen = betragOffen;
    }

    public decimal BetragOffen { get; private set; }

    public RechnungState State
    {
        get
        {
            if (BetragOffen > 0)
            {
                return RechnungState.Teilbezahlt;
            }

            if (BetragOffen == 0)
            {
                return RechnungState.Bezahlt;
            }

            return RechnungState.Ueberbezahlt;
        }
    }

    public void Add(Zahlung zahlung)
    {
        BetragOffen -= zahlung.Betrag;
    }
}