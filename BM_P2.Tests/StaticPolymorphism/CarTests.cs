using FluentAssertions;

namespace BM_P2.StaticPolymorphism;

public class CarTests
{
    private readonly Car _testee;

    public CarTests()
    {
        _testee = new Car(3);
    }

    [Fact]
    public void WhenCarDrivesForOneSecondItsSpeedShouldBeThreeKmh()
    {
        _testee.Drive().Should().Be(3);
    }
}