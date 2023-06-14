using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CubeCalculator.Interfaces;
using CubeCalculator.Model;

namespace CubeCalculator.Classes
{
    public class clsCubeIntersectionVolumen : ICubeIntersectionVolume
    {
        public double CalculateIntersectionVolume(clsCubeCalc cube1, clsCubeCalc cube2)
        {
            // Calculate the overlapping region of the two cubes
            double xOverlap = Math.Max(0, Math.Min(cube1.X + cube1.Lenght / 2, cube2.X + cube2.Lenght / 2) -
                                        Math.Max(cube1.X - cube1.Lenght / 2, cube2.X - cube2.Lenght / 2));
            double yOverlap = Math.Max(0, Math.Min(cube1.Y + cube1.Lenght / 2, cube2.Y + cube2.Lenght / 2) -
                                        Math.Max(cube1.Y - cube1.Lenght / 2, cube2.Y - cube2.Lenght / 2));
            double zOverlap = Math.Max(0, Math.Min(cube1.Z + cube1.Lenght / 2, cube2.Z + cube2.Lenght / 2) -
                                        Math.Max(cube1.Z - cube1.Lenght / 2, cube2.Z - cube2.Lenght / 2));

            // Calculate the volume of the overlapping region
            double volume = xOverlap * yOverlap * zOverlap;

            return volume;
        }

        
    }
}
