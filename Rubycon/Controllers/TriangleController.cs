using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Rubycon.Models;
using Rubycon.Services;

namespace Rubycon.Controllers
{
    public class TriangleController : ApiController
    {
        [Route("api/triangle/getcoordinates/{name}")]
        [HttpGet]
        public Triangle GetCoordinates(string name)
        {
            int[] InitialPoint = new int[2]
            {
                StringConverter.GetRow(name),
                StringConverter.GetY(name)
            };

            Triangle triangle = new Triangle
            {
                Name = name,
                PointA = new int[2] { Calculator.ToPixels(StringConverter.GetX(name)), Calculator.ToPixels(StringConverter.GetY(name)) },
                PointB = Calculator.ToPixels(Calculator.CalculateB(InitialPoint)),
                PointC = Calculator.ToPixels(Calculator.CalculateC(InitialPoint))
            };

            return triangle;
        }

        [Route("api/triangle/gettriangle/{coordinates}")]
        [HttpGet]
        public string GetTriangle(string coordinates)
        {
            ArrayList PointCoords = StringConverter.GetCoordinateArrayPixels(coordinates);
            string Name = Calculator.CalculateNamePixels(PointCoords);

            return Name;
        }
    }
}
