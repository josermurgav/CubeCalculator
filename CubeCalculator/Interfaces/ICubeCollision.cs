using CubeCalculator.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CubeCalculator.Interfaces
{
    public interface ICubeCollision
    {
        bool CheckCollision(clsCubeCalc cube1, clsCubeCalc cube2);
    }
}
