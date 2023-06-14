using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cube.Service.Model;

namespace Cube.Service.Interfaces
{
    public interface ICubeService
    {
        (bool success, string errorMsg, bool result) CheckCollision(clsCube cube1, clsCube cube2);
        (bool success, string errorMsg, double result) CalculateIntersectionVolume(clsCube cube1, clsCube cube2);
    }
}
