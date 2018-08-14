using Rubycon.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rubycon.Core.Classes
{
	class StringConverter : IStringConverter
	{
		public List<Point> ConvertCoordinates(string coordinates)
		{
			throw new NotImplementedException();
		}

		public Point GetStartingPoint(string name)
		{
			int Y = char.ToUpper(name[0]) - 65;
			int X = int.Parse(name.Remove(0, 1));

			return new Point(X, Y);
		}
	}
}
