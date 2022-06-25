using Mindbox.Interfaces;

namespace Mindbox.Models;

public class Circle : IFigure
{
    public double Area { get; }

    public Circle(double radius)
    {
        if (radius <= 0 || double.IsNaN(radius))
            throw new ArgumentException("The radius of the circle must be a positive number", nameof(radius));

        Area = Math.PI * Math.Pow(radius, 2);
    }
}