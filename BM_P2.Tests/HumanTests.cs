using FluentAssertions;

namespace BM_P2;

public class HumanTests
{
    [Fact]
    public void IndividualShouldBeHuman()
    {
        var individual = new Individual(
            "Muster", "Hans", 181,
            85);

        individual.Should().BeAssignableTo(typeof(Human));
    }
    
    [Fact]
    public void IndividualShouldBePerson()
    {
        var individual = new Individual(
            "Muster", "Hans", 181,
            85);

        individual.Should().BeAssignableTo(typeof(IPerson));
    }
}