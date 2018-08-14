using Rubycon.Core.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rubycon.Core.Interfaces
{
	public interface IStringConverter
	{
		Point GetStartingPoint(string name);

		List<Point> ConvertCoordinates(string coordinates);
	}
}
