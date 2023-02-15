public class Point
{
	public double X;
	public double Y;

	public Point(double dbX, double dbY)
	{
		X = dbX;
		Y = dbY;
	}

	public static double EuclideanDistance(Point p1, Point p2)
	{
		return Math.Sqrt(Math.Pow((p1.X - p2.X), 2.0) + Math.Pow((p1.Y - p2.Y), 2.0));
	}
}