namespace ShapeWorld.Domain.Models
{
  public abstract class Shape
  {
    //fields
    //becomes backing field when private
    //private int numberOfEdges;

    //properties- acts as a getter, setter and its own backing field
    //if set is not included, then the property can only be set by the constructor
    public int NumberOfEdges {get; }
    /* {
      get
      {
        return numberOfEdges;

      }
      set
      {
        numberOfEdges = value;

      }
    }*/

    //methods
    public virtual double Perimeter()
    {
      return 0;
    }

    public abstract double Area();

    public double Volume(){
      return 0;
    }

    //controllers
    public Shape(int edges)
    {
      NumberOfEdges = edges;  
    }
    
  }
}