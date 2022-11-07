using Math.Geometry.Base;

namespace Math.Geometry.Figures;

public class Circle : Figure
{
    public Vector2D Position { get; }
    public double Radius { get; }

    public Circle(float x, float y, double radius)
    {
        Position = new Vector2D(x, y);
        Radius = radius;
        Validate();
    }

    protected sealed override void Validate()
    {
        if (Radius < 0)
        {
            throw new ArgumentException("Radius cannot be negative");
        }
    }

    protected override double CalculateSquare()
    {
        return System.Math.PI * System.Math.Pow(Radius, 2);
    }
}