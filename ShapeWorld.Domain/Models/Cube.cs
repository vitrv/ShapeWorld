namespace ShapeWorld.Domain.Models
{
  public class Cube : Mesh
  {
    public Cube() : base(12){}
    public double EdgeLength {get; set;}
    public override double Area()
    {
      return EdgeLength * EdgeLength * EdgeLength;
    }
  }
}