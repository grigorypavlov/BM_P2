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
    }
}