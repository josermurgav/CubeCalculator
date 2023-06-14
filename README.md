# CubeManager

Project Structure:

CubeCalculator: Implements the operations of Check Colision and Calculation of Intersection of 2 Cubes

Cube.Service: Implements the service that manage the operations of check collision and Intesection

Cube.Api: Implements the API controller responsible to manage API requests

Cube.Service.Test and CubeCalculator.Test implements Unit testing for Cube.Service and CubeCalculator

All the project is implement following SOLID principles. 

The implementation follows DDD principles separating Business Domain ( CubeCalculator ) and Application Domain (Cube.Service). The last one interacts with Cube.API managing operations from Cube Calculator.
