using System.Collections.Generic;
using ShapeWorld.Domain.Models;
using System.Linq; //language integrated query
using System;

namespace ShapeWorld.Domain.Collections
{
  public class ShapeArray
  {
    public void DimensionalArray()
    {
      //1D ARRAY
      Shape[] shaped = new Shape[10];
      Shape[] shape2 = new Shape[]{new Square()};

      //2D Array, Tables, Matrixes
      Shape[,] shape3 = new Shape[2,2];
      Shape[,] shape4 = new Shape[,] {{new Square(), new Square()}, 
      {new Cube(), new Triangle()}};

      //3D
      Shape[,,] shape5 = new Shape[3,3,3];
      //Shape[,,] shape6 = new Shape[,,] = {jhgfdfghj};

      //READ
      System.Console.WriteLine(shape2[0]);
      System.Console.WriteLine(shape4[1,0]);
      //System.Console.WriteLine(shape6[1, 0, 2]); //get 12th element of 3d array

      //WRITE
      shape2[0] = new Circle();

      //jagged array, array of array
      Shape[][] shape7 = new Shape[10][];
      Shape[][] shape8 = new Shape[][]
      {
        new Rectangle[10],
        new []{new Circle(), new Circle()} //takes type of container array
      };
      System.Console.WriteLine(shape8[1][1]);
    }

    public void MyList()
    {
      List<Shape> shape1 = new List<Shape>();
      List<Shape> shape2 = new List<Shape>(); 

      List<Shape[][,,]> shape3 = new List<Shape[][,,]>(); //dont
      List<Shape[][,,]> shape4 = new List<Shape[][,,]>{new Shape [5][,,]};

      //read from list
      System.Console.WriteLine(shape2[1]);
      shape2.Find(e => e.NumberOfEdges == 12);
      shape2.FirstOrDefault(e => e.NumberOfEdges == 4);

      try
      {
        shape2[100] = new Square(); //may break if this index does not exist
      }
      catch (NullReferenceException ex)
      {
        throw; //dont handle error, let calling method handle
      }
      catch(ArgumentOutOfRangeException ex)
      {

      }
      catch (OverflowException ex)
      {
        shape2.Add(new Square());
      }
      catch (Exception ex)
      {
        throw new Exception("youuuuuuu", ex); //passes exception to calling method
      }
      finally
      {
        System.Console.WriteLine("it is final");
      }  
      shape2.AddRange(shape2); //python spread operator

      shape2.Remove(shape2[0]);

      //yield
      

    }
    public void MyDictionary()
    {
      //works like a map or vector, key value
      
      Dictionary<Shape,Shape> shape1 = new Dictionary<Shape,Shape>(); //this is hard to access
      Dictionary<string,Shape> shape2 = new Dictionary<string,Shape>(); //recommend valuetype for keys
      Dictionary<Guid,Shape> shape3 = new Dictionary<Guid,Shape>(); //Guid - alphanumeric number w/ groupings. graphical user id
    }
  }
}