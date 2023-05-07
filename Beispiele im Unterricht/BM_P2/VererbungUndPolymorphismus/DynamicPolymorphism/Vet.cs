namespace BM_P2.VererbungUndPolymorphismus.DynamicPolymorphism;

public class Vet
{
    public void Treat(IAnimal animal)
    {
        Console.WriteLine(animal.MakeSound());
    }
}