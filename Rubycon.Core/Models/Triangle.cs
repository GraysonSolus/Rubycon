using Rubycon.Core.Classes;
using Rubycon.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rubycon.Core.Models
{
	public class Triangle : IShape
	{
		[Range(2, 3)]
		public string Name { get; set; }

		[Range(3, 3)]
		public List<Point> Coordinates { get; set; }
	}
}
