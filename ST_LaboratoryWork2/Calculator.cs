using System;
using System.Collections.Generic;
using System.Text;

namespace ST_LaboratoryWork2
{
	public static class Calculator
	{
		public static double Calculate (double x)
		{
			if (x > 0)
			{
				return ((((MathFunctions.Log(x, 5) / MathFunctions.Ln(x)) - MathFunctions.Log(x, 5)) * MathFunctions.Log(x, 10)) + MathFunctions.Ln(x)) / (MathFunctions.Ln(x) / MathFunctions.Ln(x));
			}
			return ((MathFunctions.Csc(x) - MathFunctions.Power(MathFunctions.Tan(x), 3)) * MathFunctions.Sec(x) / (MathFunctions.Sin(x) - MathFunctions.Cot(x))) - MathFunctions.Sec(x);
		}

		public static double MathCalculate (double x)
		{
			if (x > 0)
			{
				return (((((Math.Log(x, 5) / Math.Log(x, Math.E)) - Math.Log(x, 5)) * Math.Log(x, 10)) + Math.Log(x, Math.E)) / (Math.Log(x, Math.E) / Math.Log(x, Math.E)));
			}
			return (((((1 / Math.Sin(x) - Math.Pow(Math.Tan(x), 3)) * 1 / Math.Cos(x)) / (Math.Sin(x) - 1 / Math.Tan(x))) - 1 / Math.Cos(x)));
		}
	}
}