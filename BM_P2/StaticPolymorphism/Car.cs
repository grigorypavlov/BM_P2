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

    public int Drive(int seconds)
    {
        return _accelerationKmhPerSecond * seconds;
    }

    public int Drive(int seconds, int maxSpeed)
    {
        if (_accelerationKmhPerSecond * seconds > maxSpeed)
        {
            return maxSpeed;
        }

        return _accelerationKmhPerSecond * seconds;
    }
}