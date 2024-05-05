namespace BM_P2.DynamicPolymorphism;

public interface IAnimal
{
    string MakeSound();
}
public interface IDriveable
{
    void Forward();
    void Backward();
}

class Car : IDriveable
{
    private readonly int _speedInKmh;

    public Car(int speedInKmh)
    {
        _speedInKmh = speedInKmh;
        RelativePosition = 0;
    }
    
    public int RelativePosition { get; private set; }

    public void Forward()
    {
        RelativePosition += _speedInKmh;
    }

    public void Backward()
    {
        RelativePosition -= _speedInKmh;
    }
}