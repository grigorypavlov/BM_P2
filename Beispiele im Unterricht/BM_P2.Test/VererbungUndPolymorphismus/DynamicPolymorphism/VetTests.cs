using BM_P2.VererbungUndPolymorphismus.DynamicPolymorphism;

namespace SW03.Test.VererbungUndPolymorphismus.DynamicPolymorphism;

public class VetTests
{
    private readonly Vet _testee;

    public VetTests()
    {
        _testee = new Vet();
    }

    [Test]
    public void TreatAnimals()
    {
        AnimalFarm animalFarm = new();
        var animals = animalFarm.GetAllAnimals();
        foreach (var animal in animals)
        {
            _testee.Treat(animal);
        }
    }
}