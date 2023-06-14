using CubeCalculator.Classes;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Cube.Service.Profiles;
using Cube.Service.Services;
using Cube.Service.Model;
using Microsoft.Extensions.Logging;
using Moq;
using CubeCalculator.Model;

namespace Cube.Service.Test.Tests
{
    [TestFixture]
    public class CubeServiceTests
    {
        [Test]
        public void SameCubeCollide()
        {
            //Arrange
            
            var cubeCollision = new clsCubeCollision();
            var cubeInterserction = new clsCubeIntersectionVolumen();

            var profile = new clsProfile();
            var configuration = new MapperConfiguration(cfg => cfg.AddProfile(profile));
            var mapper = new Mapper(configuration);
            var mockLogger = new Mock<ILogger<clsCubeService>>();

            var cubeService = new clsCubeService(cubeInterserction, cubeCollision, mapper, mockLogger.Object);


            var cube1 = new clsCube { X = 0, Y = 0, Z = 0, Lenght = 10.0 };

            //Act
            var retval = cubeService.CheckCollision(cube1, cube1);


            //Assert
            Assert.True(retval.success);
            Assert.AreEqual(retval.errorMsg,string.Empty);
            Assert.True(retval.result);

        }


        [Test]
        public void SameCubeIntersection()
        {
            //Arrange

            var cubeCollision = new clsCubeCollision();
            var cubeInterserction = new clsCubeIntersectionVolumen();

            var profile = new clsProfile();
            var configuration = new MapperConfiguration(cfg => cfg.AddProfile(profile));
            var mapper = new Mapper(configuration);
            var mockLogger = new Mock<ILogger<clsCubeService>>();

            var cubeService = new clsCubeService(cubeInterserction, cubeCollision, mapper, mockLogger.Object);


            var cube1 = new clsCube { X = 0, Y = 0, Z = 0, Lenght = 10.0 };

            //Act
            var retval = cubeService.CalculateIntersectionVolume(cube1, cube1);


            //Assert
            Assert.True(retval.success);
            Assert.AreEqual(retval.errorMsg, string.Empty);
            Assert.True(retval.result>0);

        }


        [Test]
        public void ConcentricCubesCollide()
        {
            //Arrange

            var cubeCollision = new clsCubeCollision();
            var cubeInterserction = new clsCubeIntersectionVolumen();

            var profile = new clsProfile();
            var configuration = new MapperConfiguration(cfg => cfg.AddProfile(profile));
            var mapper = new Mapper(configuration);
            var mockLogger = new Mock<ILogger<clsCubeService>>();

            var cubeService = new clsCubeService(cubeInterserction, cubeCollision, mapper, mockLogger.Object);


            var cube1 = new clsCube { X = 0, Y = 0, Z = 0, Lenght = 10.0 };
            var cube2 = new clsCube { X = 0, Y = 0, Z = 0, Lenght = 20.0 };

            //Act
            var retval = cubeService.CheckCollision(cube1, cube2);


            //Assert
            Assert.True(retval.success);
            Assert.AreEqual(retval.errorMsg, string.Empty);
            Assert.True(retval.result);

        }


        [Test]
        public void ConcentricCubesIntersection()
        {
            //Arrange

            var cubeCollision = new clsCubeCollision();
            var cubeInterserction = new clsCubeIntersectionVolumen();

            var profile = new clsProfile();
            var configuration = new MapperConfiguration(cfg => cfg.AddProfile(profile));
            var mapper = new Mapper(configuration);
            var mockLogger = new Mock<ILogger<clsCubeService>>();

            var cubeService = new clsCubeService(cubeInterserction, cubeCollision, mapper, mockLogger.Object);


            var cube1 = new clsCube { X = 0, Y = 0, Z = 0, Lenght = 10.0 };
            var cube2 = new clsCube { X = 0, Y = 0, Z = 0, Lenght = 20.0 };

            //Act
            var retval = cubeService.CalculateIntersectionVolume(cube1, cube2);


            //Assert
            Assert.True(retval.success);
            Assert.AreEqual(retval.errorMsg, string.Empty);
            Assert.True(retval.result > 0);

        }


        [Test]
        public void Distance20Lenght5NoCollide()
        {
            //Arrange

            var cubeCollision = new clsCubeCollision();
            var cubeInterserction = new clsCubeIntersectionVolumen();

            var profile = new clsProfile();
            var configuration = new MapperConfiguration(cfg => cfg.AddProfile(profile));
            var mapper = new Mapper(configuration);
            var mockLogger = new Mock<ILogger<clsCubeService>>();

            var cubeService = new clsCubeService(cubeInterserction, cubeCollision, mapper, mockLogger.Object);


            var cube1 = new clsCube { X = 0, Y = 0, Z = 20, Lenght = 5 };
            var cube2 = new clsCube { X = 0, Y = 0, Z = 0, Lenght = 5 };

            //Act
            var retval = cubeService.CheckCollision(cube1, cube2);


            //Assert
            Assert.True(retval.success);
            Assert.AreEqual(retval.errorMsg, string.Empty);
            Assert.False(retval.result);
        }


        [Test]
        public void Distance20Lenght5NoIntersection()
        {
            //Arrange

            var cubeCollision = new clsCubeCollision();
            var cubeInterserction = new clsCubeIntersectionVolumen();

            var profile = new clsProfile();
            var configuration = new MapperConfiguration(cfg => cfg.AddProfile(profile));
            var mapper = new Mapper(configuration);
            var mockLogger = new Mock<ILogger<clsCubeService>>();

            var cubeService = new clsCubeService(cubeInterserction, cubeCollision, mapper, mockLogger.Object);


            var cube1 = new clsCube { X = 0, Y = 0, Z = 20, Lenght = 5 };
            var cube2 = new clsCube { X = 0, Y = 0, Z = 0, Lenght = 5 };

            //Act
            var retval = cubeService.CalculateIntersectionVolume(cube1, cube2);


            //Assert
            Assert.True(retval.success);
            Assert.AreEqual(retval.errorMsg, string.Empty);
            Assert.False(retval.result>0);
        }
    }
}
