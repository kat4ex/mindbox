using Mindbox.Interfaces;

namespace Mindbox.Models;

public class Triangle : IFigure
{
    private readonly double[] _sidesLength;

    public double Area
    {
        get
        {
            var p = _sidesLength.Sum() / 2; // half perimeter
            
            // Heron's formula
            return Math.Sqrt(p * (p - _sidesLength[0]) * (p - _sidesLength[1]) * (p - _sidesLength[2]));
        }
    }

    public bool IsRight
    {
        get
        {
            // Sorting to find potential hypotenuse
            var sidesLength = _sidesLength.OrderBy(x => x).ToArray();

            // Pythagorean theorem
            return Math.Abs(
                Math.Pow(sidesLength[0], 2) + Math.Pow(sidesLength[1], 2) - Math.Pow(sidesLength[2], 2)
            ) < double.Epsilon; // Considering IEEE 754
        }
    }

    /// <param name="a">First side length</param>
    /// <param name="b">Second side length</param>
    /// <param name="c">Third side length</param>
    public Triangle(double a, double b, double c)
    {
        if (a <= 0 || b <= 0 || c <= 0)
            throw new ArgumentException("The length of the side must be a positive number");

        if (a + b < c || a + c < b || b + c < a)
            throw new ArgumentException("A triangle with specified sides cannot exist");

        _sidesLength = new[] { a, b, c };
    }
}