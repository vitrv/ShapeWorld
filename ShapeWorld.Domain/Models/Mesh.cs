namespace ShapeWorld.Domain.Models
{
  public abstract class Mesh : Shape
  {
    public Mesh(int edges) : base(edges){}
    public abstract override double Area();

  }
}