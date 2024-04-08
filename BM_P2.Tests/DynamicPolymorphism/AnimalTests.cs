using FluentAssertions;

namespace BM_P2.DynamicPolymorphism;

public class AnimalTests
{
    [Fact]
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
        animals.Should().HaveCount(3);
        animals[0].Should().BeOfType<Dog>();
        animals[1].Should().BeOfType<Cat>();
        animals[2].Should().BeOfType<Chicken>();
    }

    [Fact]
    public void DogShouldWoof()
    {
        var bello = new Dog();
        bello.MakeSound().Should().Be("Woof");
    }

    [Fact]
    public void CatShouldMiauw()
    {
        var ciri = new Cat();
        ciri.MakeSound().Should().Be("Miauw");
    }

    [Fact]
    public void ChickenShouldGack()
    {
        var chicken = new Chicken();
        chicken.MakeSound().Should().Be("Gack gack");
    }
}