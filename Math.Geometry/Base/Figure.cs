using System;

namespace Math.Geometry.Base;

public abstract class Figure
{
    private readonly Lazy<double> _square;

    protected Figure()
    {
        _square = new Lazy<double>(CalculateSquare);
    }

    protected abstract void Validate();

    protected abstract double CalculateSquare();
}