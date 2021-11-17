using System;
using System.IO;
using System.Text;

namespace ST_LaboratoryWork2
{
	class Program
	{
		static void Main (string[] args)
		{
			WriteFile();
		}

		private static void WriteFile (string path1 = @"D:\Institute\GitHub repositories\ST_LaboratoryWork2\sin.csv", string path2 = @"D:\Institute\GitHub repositories\ST_LaboratoryWork2\cos.csv")
		{
			using StreamWriter sw = new StreamWriter(path1, false, Encoding.Default);
			for (double i = -10; i < 10; i += 0.1)
			{
				sw.WriteLine($"{i}; {MathFunctions.Sin(i)}");
			}
			using StreamWriter sw1 = new StreamWriter(path2, false, Encoding.Default);
			for (double i = -10; i < 10; i += 0.01)
			{
				sw1.WriteLine($"{i}; {MathFunctions.Cos(i)}");
			}
		}
	}
}