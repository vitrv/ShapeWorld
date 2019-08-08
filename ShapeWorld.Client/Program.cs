using System;
using ShapeWorld.Domain.Models;

namespace ShapeWorld.Client
{

    internal class Program
    {
        //access regular return name params
        private static void Main(string[] args)
        {
          PlayWithShape();
        }

        private static void PlayWithShape(){

          Sphere someSphere = new Sphere();
          someSphere.Radius = 10;
          Console.Write(someSphere.Area());

          //Rectangle someRect = new Rectangle() as Shape; //shape cannot be real
          Rectangle someRect = new Rectangle() as Square; // casting to square, returns null if cant be cast
          //Rectangle someRect2 = (Square) new Rectangle(); // throws an exception if cant cast

        }
    }
}
//define triangle, circle, cube, sphere
//how would you find the longest word in a sentence where only whitespace matters???