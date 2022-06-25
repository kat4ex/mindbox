namespace Mindbox.Tests;

public class TriangleTests
{
    [Fact]
    public void IsAreaCorrect()
    {
        const int precision = 4;

        Assert.Equal(0.433, new Triangle(1, 1, 1).Area, precision);
        Assert.Equal(6.0, new Triangle(5, 3, 4).Area, precision);
    }

    [Fact]
    public void IsValuesCorrect()
    {
        Assert.Throws<ArgumentException>(() => new Triangle(0, 0, 0));

        Assert.Throws<ArgumentException>(() => new Triangle(-10, 10, 10));
        Assert.Throws<ArgumentException>(() => new Triangle(10, -10, 10));
        Assert.Throws<ArgumentException>(() => new Triangle(10, 10, -10));

        Assert.Throws<ArgumentException>(() => new Triangle(1, 2, 6));
    }

    [Fact]
    public void IsRightCorrect()
    {
        Assert.True(new Triangle(3, 4, 5).IsRight);
        Assert.False(new Triangle(3, 4, 6).IsRight);
    }
}