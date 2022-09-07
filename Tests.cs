using CalculateSquare;
using Xunit;

/// <summary>
/// Тесты
/// </summary>
public class CalculateSquareTests
{
    [Fact]
    public void NullCheck()
    {
        Assert.Throws<ArgumentNullException>(() => Shape.Create());
    }

    [Fact]
    public void CreateCircle()
    {
        Assert.NotNull(Shape.Create(1));
    }

    [Fact]
    public void CreateTriangle()
    {
        Assert.NotNull(Shape.Create(3, 4, 5));
    }

    [Fact]
    public void NotValidTriangle()
    {
        Assert.Throws<ArgumentOutOfRangeException>(() => Shape.Create(1, 1, 3));
    }

    [Fact]
    public void NotValidCirle()
    {
        Assert.Throws<ArgumentOutOfRangeException>(() => Shape.Create(-1));
    }

    [Fact]
    public void CircleSquare()
    {
        Assert.Equal(Math.PI, Shape.Create(1).Square());
    }

    [Fact]
    public void TriangleSquare()
    {
        Assert.Equal(6, Shape.Create(3, 4, 5).Square());
    }

    [Fact]
    public void NotRightTriangle()
    {
        var triangle = Shape.Create(4, 4, 4) as Triangle;

        Assert.False(triangle?.IsRight());
    }

    [Fact]
    public void RightTriangle()
    {
        var triangle = Shape.Create(3, 4, 5) as Triangle;

        Assert.True(triangle?.IsRight());
    }

    [Fact]
    public void RandomTriangle()
    {
        double triangleSquare = Shape.Create(7, 5, 10).Square();
        double expected = 16.248076809;
        Assert.Equal(triangleSquare, expected, tolerance: 1e-9);
    }
}
