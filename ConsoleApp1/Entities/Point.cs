internal record Point
{
  public double Y { get; init; }
  public double X { get; init; }

  public Point(double x, double y) => (X, Y) = (x, y);
}

