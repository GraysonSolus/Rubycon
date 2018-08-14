using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rubycon.Core.Classes;
namespace Rubycon.Core.Interfaces
{
	public interface IShape
	{
		string Name { get; set; }
		List<Point> Coordinates { get; set; }
	}
}
