using CubeCalculator.Interfaces;
using CubeCalculator.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CubeCalculator.Classes
{
    public class clsCubeCollision : ICubeCollision
    {
        public bool CheckCollision(clsCubeCalc cube1, clsCubeCalc cube2)
        {
            bool retval = false;
            
            //distance between center using formula
            double distance = Math.Sqrt(Math.Pow(cube2.X - cube1.X, 2) +
                                        Math.Pow(cube2.Y - cube1.Y, 2) +
                                        Math.Pow(cube2.Z - cube1.Z, 2));

               
            //min distance for intersection
            double minDistance = cube1.Lenght / 2 + cube2.Lenght / 2;

            retval = distance < minDistance;
            
            return retval;
        }
    }
}
