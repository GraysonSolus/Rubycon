using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rubycon.Core.Interfaces;
using Rubycon.Core.Models;

namespace Rubycon.Core
{
	public class ShapeFactory : IShapeFactory
	{
		public IShape GetShape(string input)
		{
			return new Triangle();
		}
	}
}
