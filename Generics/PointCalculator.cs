namespace Generics;

public class PointCalculator: ICalculator<Point>
{
    public Point Add(Point a, Point b)
    {
        return new Point()
        {
            X = a.X + b.X,
            Y = a.Y + b.Y
        };
    }

    public Point Subtract(Point a, Point b)
    {
        return new Point()
        {
            X = a.X - b.X,
            Y = a.Y - b.Y
        };
    }

    public Point Multiply(Point a, Point b)
    {
        return new Point()
        {
            X = a.X * b.X,
            Y = a.Y * b.Y
        };
    }

    public Point Divide(Point a, Point b)
    {
        return new Point()
        {
            X = a.X / b.X,
            Y = a.Y / b.Y
        };
    }
}