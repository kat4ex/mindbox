using Mindbox.Interfaces;

namespace Mindbox.Models;

public class Circle : IFigure
{
    public double Area => Math.PI * Math.Pow(_radius, 2);
    private readonly double _radius;

    public Circle(double radius)
    {
        if (radius <= 0 || double.IsNaN(radius))
            throw new ArgumentException("The radius of the circle must be a positive number", nameof(radius));

        _radius = radius;
    }
}