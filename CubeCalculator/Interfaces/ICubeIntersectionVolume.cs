using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CubeCalculator.Model;

namespace CubeCalculator.Interfaces
{
    public interface ICubeIntersectionVolume
    {        
        double CalculateIntersectionVolume(clsCubeCalc cube1, clsCubeCalc cube2);
    }
}
