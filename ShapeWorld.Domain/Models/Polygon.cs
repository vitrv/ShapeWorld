namespace ShapeWorld.Domain.Models
{
  public abstract class Polygon : Shape
  {
    public abstract override double Area();

    public Polygon(int edges) : base(edges) {}

  }
}