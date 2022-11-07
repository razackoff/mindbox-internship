using Math.Geometry.Base;

namespace Math.Geometry.Figures;

public class UnknownPolygon : Figure
{
    public List<Vector2D> ExternalPoints;

    public UnknownPolygon(params Vector2D[] dots)
    {
        ExternalPoints = dots.ToList();
        Validate();
    }

    protected sealed override void Validate()
    {
        
    }

    protected override double CalculateSquare()
    {
        double sum = 0;
        for (int i = 0; i < ExternalPoints.Count; i++)
        {
            var j = (i + 1) % ExternalPoints.Count;
            var p1 = ExternalPoints[i];
            var p2 = ExternalPoints[j];

            sum += p1.X * p2.Y - p1.Y * p2.X;
        }

        return System.Math.Abs(sum) / 2;
    }
}