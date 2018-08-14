using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rubycon.Core.Classes
{
	public struct Point
	{
		public int X, Y;

		public Point(int pX, int pY)
		{
			X = pX;
			Y = pY; 
		}

		public bool IsValid()
		{
			if (X < 0 || X > 12) {
				return false;
			}
			else if (Y < 0 || Y > 6)
			{
				return false;
			}
			else
			{
				return true;
			}
		}
	}
}
