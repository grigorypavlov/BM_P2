namespace BM_P2;

public class Payment
{
    public Payment(decimal betrag)
    {
        Betrag = betrag;
    }

    public decimal Betrag { get; }
}