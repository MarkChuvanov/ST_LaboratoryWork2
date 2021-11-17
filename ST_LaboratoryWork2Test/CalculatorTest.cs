using NUnit.Framework;
using ST_LaboratoryWork2;
using System;
using System.Collections.Generic;
using System.Text;

namespace ST_LaboratoryWork2Test
{
	[TestFixture]
	public class CalculatorTest
	{
		[Test]
		public void CalculateTest ()
		{
			for (double i = -5; i <= 5; i += 0.1)
			{
				Assert.AreEqual(Calculator.MathCalculate(i), Calculator.Calculate(i), 0.02);
			}
		}
	}
}