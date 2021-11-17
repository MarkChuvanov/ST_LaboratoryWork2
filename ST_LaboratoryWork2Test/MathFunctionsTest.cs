using NUnit.Framework;
using ST_LaboratoryWork2;
using System;

namespace ST_LaboratoryWork2Test
{
	[TestFixture]
	public class MathFunctionsTest
	{
		const double EPS = 0.01;

		[Test]
		public void AcosTest ()
		{
			int j = 0;
			// Assert.Throws<ArgumentException>(() => MathFunctions.Acos(-5));
			for (double i = -0.99; i < 1; i += 0.1)
			{
				//if (double.IsNaN(MathFunctions.Acos(i)))
				//{
				//	j++;
				//	continue;
				//}
				Assert.AreEqual(Math.Acos(i), MathFunctions.Acos(i), EPS);
			}
		}

		//	[Test]
		//	public void SinTest ()
		//	{
		//		for (double i = -10; i < 10; i += 0.01)
		//		{
		//			Assert.AreEqual(Math.Sin(i), MathFunctions.Sin(i), EPS);
		//		}
		//	}

		//	[Test]
		//	public void CosTest ()
		//	{
		//		for (double i = -10; i < 10; i += 0.01)
		//		{
		//			Assert.AreEqual(Math.Cos(i), MathFunctions.Cos(i), EPS);
		//		}
		//	}

		//	[Test]
		//	public void ExpTest ()
		//	{
		//		for (double i = -10; i < 10; i += 0.01)
		//		{
		//			Assert.AreEqual(Math.Exp(i), MathFunctions.Exp(i), EPS);
		//		}
		//	}

		//	[Test]
		//	public void TanTest ()
		//	{
		//		for (double i = -10; i < 10; i += 0.01)
		//		{
		//			Assert.AreEqual(Math.Tan(i), MathFunctions.Tan(i), EPS);
		//		}
		//	}

		//	[Test]
		//	public void CotTest ()
		//	{
		//		for (double i = -10; i < 10; i += 0.01)
		//		{
		//			Assert.AreEqual(1 / Math.Tan(i), MathFunctions.Cot(i), EPS);
		//		}
		//	}

		//	[Test]
		//	public void SecTest ()
		//	{
		//		for (double i = -10; i < 10; i += 0.01)
		//		{
		//			Assert.AreEqual(1 / Math.Cos(i), MathFunctions.Sec(i), EPS);
		//		}
		//	}

		//	[Test]
		//	public void CscTest ()
		//	{
		//		for (double i = -10; i < 10; i += 0.01)
		//		{
		//			Assert.AreEqual(1 / Math.Sin(i), MathFunctions.Csc(i), EPS);
		//		}
		//	}

		//	[Test]
		//	public void AbsTest ()
		//	{
		//		for (double i = -10; i < 10; i += 0.01)
		//		{
		//			Assert.AreEqual(Math.Abs(i), MathFunctions.Abs(i), EPS);
		//		}
		//	}

		//	[Test]
		//	public void PowerTest ()
		//	{
		//		for (double i = -10; i <= 10; i += 0.01)
		//		{
		//			for (int index = -5; index <= 5; index++)
		//			{
		//				Assert.AreEqual(Math.Pow(i, index), MathFunctions.Power(i, index), EPS);
		//			}
		//		}
		//	}

		//	[Test]
		//	public void LogTest ()
		//	{
		//		for (int newBase = -5; newBase <= 5; newBase++)
		//		{				
		//			if (newBase == 1) continue;
		//			for (double i = -5; i <= 5; i += 0.01)
		//			{
		//				Assert.AreEqual(Math.Log(i, newBase), MathFunctions.Log(i, newBase), 0.1);
		//			}
		//		}
		//	}

		//	[Test]
		//	public void FactorialTest ()
		//	{
		//		Assert.Throws<ArgumentException>(() => MathFunctions.Factorial(-5));
		//		Assert.AreEqual(120, MathFunctions.Factorial(5));
		//		Assert.AreEqual(1, MathFunctions.Factorial(0));
		//	}
	}
}