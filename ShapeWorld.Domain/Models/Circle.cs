namespace ShapeWorld.Domain.Models
{
  public class Circle : Polygon
  {
    public Circle() : base(1){}
    public double Radius {get; set;}
    public override double Area()
    {
        return 3.14 * Radius * Radius;
    }
  }
}