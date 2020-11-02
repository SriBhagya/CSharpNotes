using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NormalCalculator;

namespace CallDLLEg
{
	class Employee
	{
		static void Main()
		{
			Calculator calculator = new Calculator();
			Console.WriteLine("addition of two numbers:{0}", calculator.Addition(10,13));
			Console.ReadLine();
		}
	}
}
