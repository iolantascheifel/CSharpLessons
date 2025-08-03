namespace Generics;

public class PointComparer: IComparer<Point>
{
    public int Compare(Point x, Point y)
    {
        int sumX = x.X + x.Y;
        int sumY = y.X + y.Y;
        if (sumX < sumY)
        {
            return -1;
        } 
        else if (sumX > sumY)
        {
            return 1;
        }
        return 0;
    }
}