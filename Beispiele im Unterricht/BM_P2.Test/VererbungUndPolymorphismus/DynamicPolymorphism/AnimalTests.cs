using BM_P2.VererbungUndPolymorphismus.DynamicPolymorphism;
using FluentAssertions;

namespace SW03.Test.VererbungUndPolymorphismus.DynamicPolymorphism;

public class AnimalTests
{
    [Test]
    public void AnimalsShouldMakeSounds()
    {
        var animalFarm = new AnimalFarm();
        var animals = animalFarm.GetAllAnimals().ToList();
        
        animals.ForEach(animal =>
        {
            var animalSound = animal.MakeSound();
            Console.WriteLine(animalSound);
            
            animalSound.Should().NotBeEmpty();
        });
    }

    [Test]
    public void DogShouldWoof()
    {
        var bello = new Dog();
        bello.MakeSound().Should().Be("Woof");
    }

    [Test]
    public void CatShouldMiauw()
    {
        var ciri = new Cat();
        ciri.MakeSound().Should().Be("Miauw");
    }

    [Test]
    public void ChickenShouldGack()
    {
        var chicken = new Chicken();
        chicken.MakeSound().Should().Be("Gack gack");
    }
}