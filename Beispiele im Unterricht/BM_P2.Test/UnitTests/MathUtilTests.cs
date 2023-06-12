namespace SW03.Test.UnitTests;

[TestFixture]
public class MathUtilTests
{
    [Test]
    public void Add_WhenCalled_ReturnsSumOfTwoNumbers()
    {
        // Arrange
        MathUtil mathUtil = new MathUtil();
        int a = 5;
        int b = 10;

        // Act
        int result = mathUtil.Add(a, b);

        // Assert
        Assert.AreEqual(15, result);
    }
}

public class MathUtil
{
    public int Add(int i, int i1)
    {
        return i + i1;
    }
}