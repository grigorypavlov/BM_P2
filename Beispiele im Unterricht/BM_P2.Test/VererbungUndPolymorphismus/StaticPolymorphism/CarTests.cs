using BM_P2.VererbungUndPolymorphismus.WeakPolymorphism;
using FluentAssertions;

namespace SW03.Test.VererbungUndPolymorphismus.WeakPolymorphism;

public class CarTests
{
    private readonly Car _testee;

    public CarTests()
    {
        _testee = new Car(3);
    }

    [Test]
    public void WhenCarDrivesForOneSecondItsSpeedShouldBeThreeKmh()
    {
        _testee.Drive().Should().Be(3);
    }

    [Test]
    public void WhenCarDrivesForTwoSecondsItsSpeedIsSixKmh()
    {
        _testee.Drive(2).Should().Be(6);
    }

    [Test]
    public void WhenCarDrivesForSixSecondsWithMaxSpeedLimitItsSpeedShouldNotBeHigherThanTheSpeedLimit()
    {
        _testee.Drive(6, 3).Should().Be(3);
    }
}