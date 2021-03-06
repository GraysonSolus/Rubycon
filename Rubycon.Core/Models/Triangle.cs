﻿using Rubycon.Core.Classes;
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
		public Triangle(string name)
		{
			Name = name;
		}

		[Range(2, 3)]
		public string Name { get; set; }
		public List<Point> Coordinates { get; set; }
	}
}
