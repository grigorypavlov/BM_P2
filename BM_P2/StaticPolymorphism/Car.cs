namespace BM_P2.StaticPolymorphism;

public class Car
{
    private readonly int _accelerationKmhPerSecond;

    public Car(int accelerationKmhPerSecond)
    {
        this._accelerationKmhPerSecond = accelerationKmhPerSecond;
    }

    public int Drive()
    {
        return _accelerationKmhPerSecond;
    }
}