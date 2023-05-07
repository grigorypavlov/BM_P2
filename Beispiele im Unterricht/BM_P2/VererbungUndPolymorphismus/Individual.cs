namespace BM_P2.VererbungUndPolymorphismus;

public class Individual
{
    public Individual(
        string name,
        string firstName,
        int sizeInCm,
        int weightInKg)
    {
        Name = name;
        FirstName = firstName;
        SizeInCm = sizeInCm;
        WeightInKg = weightInKg;
    }

    public string Name { get; }

    public string FirstName { get; }

    public int SizeInCm { get; }
    
    public int WeightInKg { get; }
}