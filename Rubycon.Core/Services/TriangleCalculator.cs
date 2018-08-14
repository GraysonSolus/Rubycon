using Rubycon.Core.Classes;
using Rubycon.Core.Interfaces;
using Rubycon.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rubycon.Core.Services
{
	class TriangleCalculator : IShapeCalculator
	{
		private int Ax, Ay, Bx, By, Cx, Cy;
		Point PointA, PointB, PointC;

		private readonly IStringConverter _stringConverter;

		public TriangleCalculator(IStringConverter stringConverter)
		{
			_stringConverter = stringConverter;
		}


		public IShape GetByName(string name)
		{
			Point initialPoint = _stringConverter.GetStartingPoint(name);

			int iX = initialPoint.X;
			int iY = initialPoint.Y;

			if (iX % 2 == 0)
			{
				Ax = (iX / 2) - 1;
				Ay = iY;

				Bx = (iX / 2);
				By = iY;

				Cx = (iX / 2);
				Cy = iY + 1;
			}
			else
			{
				Ax = (iX - 1) / 2;
				Ay = iY;

				Bx = (iX - 1) / 2;
				By = iY + 1;

				Cx = (iX + 1) / 2;
				Cy = iY + 1;
			}

			PointA.X = Ax;
			PointA.Y = Ay;
			PointB.X = Bx;
			PointB.Y = By;
			PointC.X = Cx;
			PointC.Y = Cy;

			List<Point> Points = new List<Point>
			{
				PointA,
				PointB,
				PointC
			};

			Triangle triangle = new Triangle(name)
			{
				Coordinates = Points
			};

			return triangle;

		}

		public string GetByPoints(string coordinates)
		{
			throw new NotImplementedException();
		}
	}
}
