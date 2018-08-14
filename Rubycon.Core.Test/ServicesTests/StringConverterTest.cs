using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Rubycon.Core.Classes;

namespace Rubycon.Core.Test.ServicesTests
{
	[TestClass]
	public class StringConverterTest
	{
		[TestMethod]
		public void CalculateStartingPointCoordinates()
		{
			StringConverter sc = new StringConverter();
			string input = "A1";

			Point p = sc.GetStartingPoint(input);

			Assert.IsTrue(p.X == 1 && p.Y == 0);
		}

		[TestMethod]
		[ExpectedException(typeof(ArgumentNullException))]
		public void NullOrEmptyArgumentThrowsException()
		{
			StringConverter sc = new StringConverter();
			string input = "";

			Point p = sc.GetStartingPoint(input);
		}

		[TestMethod]
		[ExpectedException(typeof(ArgumentOutOfRangeException))]
		public void InvalidPointThrowsArgumentOutOfRangeException()
		{
			StringConverter sc = new StringConverter();
			string input = "X100";

			Point p = sc.GetStartingPoint(input);
		}

		[TestMethod]
		[ExpectedException(typeof(FormatException))]
		public void InvalidNameThrowsArgumentException()
		{
			StringConverter sc = new StringConverter();
			string input = "9A";

			Point p = sc.GetStartingPoint(input);
		}
	}
}
