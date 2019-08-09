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

    public override string ToString()
    {
      //return $"{NumberOfEdges}"; //notifies that something needs to be evaluated into a string
      return $"{this.GetType().Name} {NumberOfEdges} edges"; //reflection: allows connection to object underneath runtime engine to get properties at runtime
    }

    //controllers
    public Shape(int edges)
    {
      NumberOfEdges = edges;  
    }
    
  }
}