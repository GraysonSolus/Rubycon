using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rubycon.Core.Interfaces
{
	public interface IShapeCalculator
	{
		IShape GetByName(string name);
		string GetByPoints(string coordinates);
	}
}
