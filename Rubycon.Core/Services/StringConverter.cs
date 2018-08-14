using Rubycon.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rubycon.Core.Classes
{
	public class StringConverter : IStringConverter
	{
		public List<Point> ConvertCoordinates(string coordinates)
		{
			throw new NotImplementedException();
		}

		public Point GetStartingPoint(string name)
		{
			Point p;

			if (String.IsNullOrEmpty(name))
			{
				throw new ArgumentNullException(name, "cannot be null or empty");
			}

			try
			{
				p.Y = char.ToUpper(name[0]) - 65;
				p.X = int.Parse(name.Remove(0, 1));

				if (!p.IsValid())
				{
					throw new ArgumentOutOfRangeException("Point", p, "Point p is not a valid point");
				}
			}
			catch (FormatException e)
			{
				Console.WriteLine(e.Message);
				Console.WriteLine(e.StackTrace);
				throw;
			}
			catch (Exception e)
			{
				Console.WriteLine(e.Message);
				Console.WriteLine(e.StackTrace);
				throw;
			}

			return p;		
		}
	}
}
