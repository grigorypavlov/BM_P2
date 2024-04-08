namespace BM_P2;

public abstract class Human
{
    public Human(int sizeInCm, int weightInKg)
    {
        SizeInCm = sizeInCm;
        WeightInKg = weightInKg;
    }
    
    public int WeightInKg { get; }

    public int SizeInCm { get; }
}