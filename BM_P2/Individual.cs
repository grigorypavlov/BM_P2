namespace BM_P2;

public class Individual : Human, IPerson
{
    public Individual(
        string name,
        string firstName,
        int sizeInCm,
        int weightInKg) : base(sizeInCm, weightInKg)
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