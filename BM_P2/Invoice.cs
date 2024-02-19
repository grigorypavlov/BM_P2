namespace BM_P2;

public class Invoice
{
    public Invoice(decimal amount)
    {
        Amount = amount;
        AmountOpen = amount;
    }
    
    // TODO: Properties sollten Readonly sein.
    public decimal Amount { get; set; }
    public decimal AmountOpen { get; set; }
}