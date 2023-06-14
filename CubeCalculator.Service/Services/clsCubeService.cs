using Cube.Service.Interfaces;
using Cube.Service.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CubeCalculator.Interfaces;
using AutoMapper;
using CubeCalculator.Model;
using Microsoft.Extensions.Logging;

namespace Cube.Service.Services
{
    public class clsCubeService : ICubeService
    {
        ICubeIntersectionVolume _calculateIntersection;
        ICubeCollision _caculateCollision;
        private readonly IMapper _mapper;
        private readonly ILogger<clsCubeService> _logger;
        public clsCubeService(ICubeIntersectionVolume calculateInt, ICubeCollision caculateCol, IMapper mapper, ILogger<clsCubeService> logger)
        {
            _calculateIntersection = calculateInt;
            _caculateCollision = caculateCol;
            _mapper = mapper;
            _logger = logger;   
        }

        //tupple<success,errorMsg,result>
        public (bool success ,string errorMsg ,double result) CalculateIntersectionVolume(clsCube cube1, clsCube cube2)
        {
            bool success = true;
            string errorMsg=string.Empty;
            double result = 0.0;
            try
            {
                var calcCube1 = _mapper.Map<clsCubeCalc>(cube1);
                var calcCube2 = _mapper.Map<clsCubeCalc>(cube2);

                 result= _calculateIntersection.CalculateIntersectionVolume(calcCube1, calcCube2);
                
            }
            catch (Exception ex)
            {

                _logger?.LogError(ex.ToString());
                return (false, ex.ToString(), 0.0);
            }


            return (success,errorMsg,result);
        }

        public (bool success, string errorMsg, bool result) CheckCollision(clsCube cube1, clsCube cube2)
        {
            bool success = true;
            string errorMsg = string.Empty;
            bool result = false;

            try
            {
                var calcCube1 = _mapper.Map<clsCubeCalc>(cube1);
                var calcCube2 = _mapper.Map<clsCubeCalc>(cube2);

                result= _caculateCollision.CheckCollision(calcCube1, calcCube2);
            }
            catch (Exception ex)
            {

                _logger?.LogError(ex.ToString());
                return (false, ex.ToString(), false);
            }

            return(success,errorMsg,result);
        }
    }
}
