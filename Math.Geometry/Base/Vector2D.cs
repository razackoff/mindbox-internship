namespace Math.Geometry.Base;

public class Vector2D
{
    public const double Tolerance = 0.001;

    public Vector2D(float x, float y)
    {
        X = x;
        Y = y;
    }

    public float X { get; }
    public float Y { get; }
}