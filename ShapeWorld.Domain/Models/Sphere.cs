namespace ShapeWorld.Domain.Models
{
  public class Sphere : Mesh
  {
    public Sphere() : base(0) {}
    public double Radius {get; set;}
    public override double Area()
    {
      return 20;
    }

  }
}