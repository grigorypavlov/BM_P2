namespace SW03.Test.UnitTests;

[TestFixture]
public class StringHelperTests
{
    [Test]
    public void ReverseString_WhenCalled_ReturnsReversedString()
    {
        // Arrange
        StringHelper stringHelper = new StringHelper();
        string input = "Hello, World!";

        // Act
        string result = stringHelper.ReverseString(input);

        // Assert
        Assert.AreEqual("!dlroW ,olleH", result);
    }

    [Test]
    public void ReverseString_WhenCalledWithEmptyString_ReturnsEmptyString()
    {
        // Arrange
        StringHelper stringHelper = new StringHelper();
        string input = "";

        // Act
        string result = stringHelper.ReverseString(input);

        // Assert
        Assert.AreEqual("", result);
    }
}