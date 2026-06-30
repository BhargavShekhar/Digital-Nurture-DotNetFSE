using NUnit.Framework;

namespace CalcLibrary.Tests;

[TestFixture]
public class CalculatorTests
{
    private SimpleCalculator _calculator = null!;

    [SetUp]
    public void Setup()
    {
        _calculator = new SimpleCalculator();
    }

    [TearDown]
    public void TearDown()
    {
        _calculator = null!;
    }

    [Test]
    [TestCase(2, 3, 5)]
    [TestCase(10, 20, 30)]
    [TestCase(-1, 5, 4)]
    public void Addition_ShouldReturnExpectedResult(double a, double b, double expected)
    {
        double actual = _calculator.Addition(a, b);

        Assert.That(actual, Is.EqualTo(expected));
    }
}