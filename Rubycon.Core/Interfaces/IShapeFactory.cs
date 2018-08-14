using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rubycon.Core.Interfaces;

namespace Rubycon.Core
{
	public interface IShapeFactory
	{
		 IShape GetShape(string input);
	}
}
