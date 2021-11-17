using System;
using System.Collections.Generic;
using System.Text;

namespace ST_LaboratoryWork2
{
	public static class MathFunctions
	{
		public static double Acos (double x)
		{
			if (Abs(x) >= 1)
			{
				throw new ArgumentException("Входное значение по модулю не может быть большим или равным 1");
			}
			double eps = 0.0000001;
			double result = 0.0;
			int n = 1;
			double expression;
			do
			{
				expression = (Factorial(2 * n) / (Power(4, n) * Power(Factorial(n), 2) * (2 * n + 1))) * Power(x, 2 * n + 1);
				result += expression;
				n++;
			}
			while (Abs(expression) < eps);
			return Math.PI / 2 - result;
			//double result = x;
			//double a = x;
			//int i = 1;

			//while (a < 0.000001)
			//{
			//	a *= x * x * (2 * i - 1) * (2 * i - 1) / ((2 * i + 1) * 2 * i);
			//	result += a;
			//	i++;
			//}
			//return Math.PI / 2 - result;
		}

		public static double Sin (double x, int nTerms = 30)
		{
			if (nTerms < 2)
			{
				return x;
			}
			if (nTerms == 2)
			{
				return x - (x * x * x) / 6D;
			}
			double multiplyResult = x * x * x;
			double factorialStart = 5;
			double factorialResult = 6;
			double result = x - multiplyResult / factorialResult;
			double sign = 1;
			for (int i = 3; i <= nTerms; i++)
			{
				multiplyResult *= x * x;
				factorialResult *= factorialStart * (factorialStart - 1);
				factorialStart += 2;
				result += sign * (multiplyResult / factorialResult);
				sign *= -1;
			}
			return result;
		}

		public static double Cos (double x, int nTerms = 30)
		{
			if (nTerms < 2)
			{
				return 1;
			}
			if (nTerms == 2)
			{
				return 1 - (x * x) / 2D;
			}
			double multiplyResult = x * x;
			double factorialStart = 4;
			double factorialResult = 2;
			double result = 1 - multiplyResult / factorialResult;
			double sign = 1;

			for (int i = 3; i <= nTerms; i++)
			{
				multiplyResult *= x * x;
				factorialResult *= factorialStart * (factorialStart - 1);
				factorialStart += 2;
				result += sign * (multiplyResult / factorialResult);
				sign *= -1;
			}
			return result;
		}

		public static double Ln (double power)
		{
			if (power == 0)
			{
				return double.NegativeInfinity;
			}
			if (power == 1)
			{
				return 0;
			}
			const double e = 2.71828182845905;
			double p = power;
			double n = 0.0;
			double a;
			while (p >= e)
			{
				p /= e;
				n++;
			}
			n += (p / e);
			p = power;
			do
			{
				a = n;
				double l = (p / (Exp(n - 1.0)));
				double r = ((n - 1.0) * e);
				n = ((l + r) / e);
			} while (Abs(n - a) > 0.001);
			return n;
		}

		public static double Log (double x, double @base)
		{
			if (@base <= 0 || x <= 0)
			{
				return double.NaN;
			}
			return Ln(x) / Ln(@base);
		}

		public static double Exp (double n)
		{
			double x = n;
			double p = 1.0 + x;
			double factorial = x;
			double i = 1.0;
			double l;
			do
			{
				i++;
				factorial *= (x / i);
				l = p;
				p += factorial;
			} while (Abs(l - p) > 0.001);
			return p;
		}

		public static double Tan (double x)
		{
			return Sin(x) / Cos(x);
		}

		public static double Cot (double x)
		{
			return Cos(x) / Sin(x);
		}

		public static double Sec (double x)
		{
			return 1 / Cos(x);
		}

		public static double Csc (double x)
		{
			return 1 / Sin(x);
		}

		public static double Abs (double x)
		{
			return x >= 0 ? x : -x;
		}

		public static double Power (double x, int n)
		{
			if (n == 0)
			{
				return 1;
			}
			if (n > 0)
			{
				if (n % 2 == 0)
				{
					double p = Power(x, n / 2);
					return p * p;
				}
				else
				{
					return x * Power(x, n - 1);
				}
			}
			else
			{
				double result = 1;
				for (int i = 1; i <= -n; i++)
				{
					result *= x;
				}
				return 1 / result;
			}
		}

		public static int Factorial (int x)
		{
			if (x < 0)
			{
				throw new ArgumentException("Входное значение не может быть отрицательным");
			}
			else
			{
				int result = 1;
				for (int i = 1; i <= x; i++)
				{
					result *= i;
				}
				return result;
			}
		}
	}
}