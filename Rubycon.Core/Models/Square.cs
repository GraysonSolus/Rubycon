using Rubycon.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rubycon.Core.Classes;
namespace Rubycon.Core.Models
{
	public class Square : IShape
	{
		[Range(2, 3)]
		public string Name { get; set; }
		
		[Range(4, 4)]
		public List<Point> Coordinates { get; set; }
	}
}
