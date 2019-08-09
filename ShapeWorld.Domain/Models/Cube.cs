using ShapeWorld.Domain.Interfaces;

namespace ShapeWorld.Domain.Models
{
  public class Cube : Square, IThreeD
  {
    //public Cube() : base(12){}
    public double EdgeLength {get; set;}
    public double Height { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }

    public override double Area()
    {
      return EdgeLength * EdgeLength * EdgeLength;
    }
  }
}