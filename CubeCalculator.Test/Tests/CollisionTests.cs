using CubeCalculator.Classes;
using CubeCalculator.Model;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CubeCalculator.Test.Tests
{
    [TestFixture]
    public class CollisionTests
    {
        [Test]
        public void SameCubeCollide()
        { 
            //arrange
            clsCubeCalc cube1 = new clsCubeCalc { X=0,Y=0, Z=0,Lenght=10.0 };

            //act
            var result = new clsCubeCollision().CheckCollision(cube1,cube1);

            //assert
            Assert.True(result);
        }


        [Test]
        public void ConcentricCubesCollide()
        {
            //arrange
            clsCubeCalc cube1 = new clsCubeCalc { X = 0, Y = 0, Z = 0, Lenght = 10.0 };
            clsCubeCalc cube2 = new clsCubeCalc { X = 0, Y = 0, Z = 0, Lenght = 20.0 };

            //act
            var result = new clsCubeCollision().CheckCollision(cube1, cube2);

            //assert
            Assert.True(result);
        }


        
        [Test]
        public void Distance20Lenght5NoCollide()
        {
            //arrange
            clsCubeCalc cube1 = new clsCubeCalc { X = 0, Y = 0, Z = 0, Lenght = 5 };
            clsCubeCalc cube2 = new clsCubeCalc { X = 0, Y = 0, Z = 10, Lenght = 5 };

            //act
            var result = new clsCubeCollision().CheckCollision(cube1, cube2);

            //assert
            Assert.False(result);
        }

        [Test]
        public void Distance10Lenght10Collide()
        {
            //arrange
            clsCubeCalc cube1 = new clsCubeCalc { X = 0, Y = 0, Z = 0, Lenght = 10 };
            clsCubeCalc cube2 = new clsCubeCalc { X = 0, Y = 0, Z = 10, Lenght = 10 };

            //act
            var result = new clsCubeCollision().CheckCollision(cube1, cube2);

            //assert
            Assert.False(result);
        }

    }
}
