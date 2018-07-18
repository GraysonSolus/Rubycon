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
        public Triangle GetCoords(string name)
        {
            ArrayList InitialPoint = new ArrayList
            {
                NameConverter.GetRow(name),
                NameConverter.GetY(name)
            };

            Triangle triangle = new Triangle
            {
                Name = name,
                PointA = new ArrayList { NameConverter.GetX(name), NameConverter.GetY(name) },
                PointB = PointCalculator.CalculateB(InitialPoint),
                PointC = PointCalculator.CalculateC(InitialPoint)
            };

            return triangle;
        }
    }
}
