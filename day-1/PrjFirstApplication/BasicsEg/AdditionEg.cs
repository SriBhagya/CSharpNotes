using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicsEg
{
	class AdditionEg
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Please enter two numbers to add sub multiply div");
			int num1, num2;
			int add, sub, multiply, div;

			Console.WriteLine("Please enter first number");
			num1 = Convert.ToInt32(Console.ReadLine());
			num2 = Convert.ToInt32(Console.ReadLine());

			add = num1 + num2;
			sub = num1 - num2;
			multiply = num1 * num2;
			div = num1 / num2;

			Console.WriteLine("Results");
			Console.WriteLine("Addition {0}", add);
			Console.WriteLine("Substraction {0}", sub);
			Console.WriteLine("Multiplication {0}", multiply);
			Console.WriteLine("Division {0}", div);
			Console.ReadLine();

		}
	}
}
