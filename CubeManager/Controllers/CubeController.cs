
using Cube.Api.Model;
using Cube.Service.Interfaces;
using Cube.Service.Model;
using Microsoft.AspNetCore.Mvc;

namespace Cube.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CubeController : ControllerBase
    {
        
        ICubeService _cubeService;
        
        public CubeController(ICubeService cubeService)
        {
            _cubeService = cubeService;
            
        }

        //qui post per richiesta calcolo collision
        [HttpPost("CheckCollision")]
        public IActionResult CheckCollision([FromBody] CubeCalculateRequest request)
        {
            clsCube cube1 = new clsCube {
                X = request.Cube1X,
                Y = request.Cube1Y,
                Z = request.Cube1Z,
                Lenght = request.Cube1Lenght
            };

            clsCube cube2 = new clsCube
            {
                X = request.Cube2X,
                Y = request.Cube2Y,
                Z = request.Cube2Z,
                Lenght = request.Cube2Lenght
            };

            var resultcalc= _cubeService.CheckCollision(cube1, cube2);

            if (resultcalc.success)
            {
                return Ok(resultcalc.result);
            }

            return BadRequest();
            
        }

        //qui post per richiesta calcolo collision
        [HttpPost("CalculateIntersection")]
        public IActionResult CalculateIntersection([FromBody]  CubeCalculateRequest request)
        {

            clsCube cube1 = new clsCube
            {
                X = request.Cube1X,
                Y = request.Cube1Y,
                Z = request.Cube1Z,
                Lenght = request.Cube1Lenght
            };

            clsCube cube2 = new clsCube
            {
                X = request.Cube2X,
                Y = request.Cube2Y,
                Z = request.Cube2Z,
                Lenght = request.Cube2Lenght
            };

            var resultcalc = _cubeService.CalculateIntersectionVolume(cube1, cube2);

            if (resultcalc.success)
            {
                return Ok(resultcalc.result);
            }

            return BadRequest();
        }
    }
}
