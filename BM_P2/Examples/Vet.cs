namespace BM_P2.Examples;

public class Vet
{
    public void Treat(Animal animal)
    {
        if (!animal.IsImmune)
        {
            animal.ReceiveVaccine();
        }
    }
}

public abstract class Animal
{
    protected int VaccinesRecieved = 0;
    public abstract bool IsImmune { get; }

    public void ReceiveVaccine()
    {
        VaccinesRecieved++;
    }
}

public class Dog : Animal
{
    private const int ImmunizationCount = 2;

    public override bool IsImmune
    {
        get
        {
            return VaccinesRecieved == ImmunizationCount;
        }
    }
}

public class Cat : Animal
{
    private const int ImmunizationCount = 4;
    private DateTime lastVaccineReceived;

    public override bool IsImmune
    {
        get
        {
            return VaccinesRecieved == ImmunizationCount &&
                   DateTime.Now - lastVaccineReceived < TimeSpan.FromHours(365 * 24);
        }
    }
}

public class Chicken : Animal
{
    private const int ImmunizationCount = 3;

    public override bool IsImmune
    {
        get
        {
            return VaccinesRecieved == ImmunizationCount;
        }
    }
}

