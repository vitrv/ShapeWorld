namespace ShapeWorld.Domain.Models
{
  public class Triangle : Polygon
  {
    public Triangle() : base(3){}
    public double BaseLength {get; set;}
    public double Height {get; set;}
    public override double Area()
    {
      return 0.5 * BaseLength * Height;
    }

  }
}