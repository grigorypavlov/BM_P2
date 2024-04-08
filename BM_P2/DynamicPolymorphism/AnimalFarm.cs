namespace BM_P2.DynamicPolymorphism;

public class AnimalFarm
{
    public IEnumerable<IAnimal> GetAllAnimals()
    {
        var animals = new List<IAnimal>();
        animals.Add(new Dog());
        animals.Add(new Cat());
        return animals;
    }
}