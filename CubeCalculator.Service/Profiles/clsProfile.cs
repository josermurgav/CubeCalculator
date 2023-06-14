using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CubeCalculator.Model;
using AutoMapper;
using Cube.Service.Model;

namespace Cube.Service.Profiles
{
    public class clsProfile : Profile
    {
        public clsProfile()
        {
            CreateMap<clsCubeCalc,clsCube>();
            CreateMap<clsCube,clsCubeCalc>();
        }
    }
}
