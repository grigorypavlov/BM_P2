namespace BM_P2.Examples2;

public class Animal
{
    private IEatingBehavior _eatingBehavior;

    public Animal(IEatingBehavior eatingBehavior)
    {
        _eatingBehavior = eatingBehavior;
    }

    public void Eat()
    {
        _eatingBehavior.Eat();
    }
}

public interface IEatingBehavior
{
    void Eat();
}

public class Herbivore : IEatingBehavior
{
    public void Eat()
    {
        Console.WriteLine("Herbivore is eating plants");
    }
}

public class Carnivore : IEatingBehavior
{
    public void Eat()
    {
        Console.WriteLine("Carnivore is eating meat");
    }
}