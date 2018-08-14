using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Rubycon.Core.Interfaces;
using Rubycon.Core.Models;

namespace Rubycon.Core.Test
{
	[TestClass]
	public class ShapeFactoryTest
	{
		[TestMethod]
		public void ReturnTriangle()
		{
			ShapeFactory sf = new ShapeFactory();
			string input = "0,0; 0,1; 1,1";
			IShape tri = sf.GetShape(input);

			Assert.IsTrue(tri is Triangle);
		}

		[TestMethod]
		public void WrongInputFormatThrowsException()
		{
			Assert.Inconclusive();
		}

		[TestMethod]
		public void InputNullOrEmptyThrowsException()
		{
			Assert.Inconclusive();
		}
	}
}
