using CubeCalculator.Classes;
using CubeCalculator.Model;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CubeCalculator.Test.Tests
{
    public class IntersectionTests
    {
        [Test]
        public void SameCubeIntersection()
        {
            //arrange
            clsCubeCalc cube1 = new clsCubeCalc { X = 0, Y = 0, Z = 0, Lenght = 10.0 };

            //act
            var result = new clsCubeIntersectionVolumen().CalculateIntersectionVolume(cube1, cube1);

            //assert
            Assert.True(result>0);
        }


        [Test]
        public void ConcentricCubesIntersection()
        {
            //arrange
            clsCubeCalc cube1 = new clsCubeCalc { X = 0, Y = 0, Z = 0, Lenght = 10.0 };
            clsCubeCalc cube2 = new clsCubeCalc { X = 0, Y = 0, Z = 0, Lenght = 20.0 };

            //act
            var result = new clsCubeIntersectionVolumen().CalculateIntersectionVolume(cube1, cube2);

            //assert
            Assert.True(result > 0);
        }



        [Test]
        public void Distance20Lenght5NoIntersection()
        {
            //arrange
            clsCubeCalc cube1 = new clsCubeCalc { X = 0, Y = 0, Z = 0, Lenght = 5 };
            clsCubeCalc cube2 = new clsCubeCalc { X = 0, Y = 0, Z = 10, Lenght = 5 };

            //act
            var result = new clsCubeIntersectionVolumen().CalculateIntersectionVolume(cube1, cube2);

            //assert
            Assert.False(result > 0);
        }

        [Test]
        public void Distance10Lenght10NoIntersection()
        {
            //arrange
            clsCubeCalc cube1 = new clsCubeCalc { X = 0, Y = 0, Z = 0, Lenght = 10 };
            clsCubeCalc cube2 = new clsCubeCalc { X = 0, Y = 0, Z = 10, Lenght = 10 };

            //act
            var result = new clsCubeIntersectionVolumen().CalculateIntersectionVolume(cube1, cube2);

            //assert
            Assert.False(result > 0);
        }
    }
}
