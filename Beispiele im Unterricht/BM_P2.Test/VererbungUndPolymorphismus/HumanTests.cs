using BM_P2.VererbungUndPolymorphismus;
using FluentAssertions;

namespace SW03.Test.VererbungUndPolymorphismus;

public class HumanTests
{
    [Test]
    public void IndividualShouldBeHuman()
    {
        var individual = new Individual(
            "Muster", "Hans", 181,
            85);

        individual.Should().BeAssignableTo(typeof(Human));
    }
    
    [Test]
    public void IndividualShouldBePerson()
    {
        var individual = new Individual(
            "Muster", "Hans", 181,
            85);

        individual.Should().BeAssignableTo(typeof(IPerson));
    }
}