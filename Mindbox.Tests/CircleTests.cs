namespace Mindbox.Tests;

public class CircleTests
{
    [Fact]
    public void IsAreaCorrect()
    {
        Assert.Equal(Math.PI, new Circle(1).Area);
        Assert.Equal(Math.PI * 4, new Circle(2).Area);
    }

    [Fact]
    public void IsValuesCorrect()
    {
        Assert.Throws<ArgumentException>(() => new Circle(0).Area);
        Assert.Throws<ArgumentException>(() => new Circle(-5).Area);
        Assert.Throws<ArgumentException>(() => new Circle(double.NaN).Area);
    }
}