using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicsEg
{
	class InputFromUserEg
	{
		static void Main()
		{
			string name, city;
			int age;
			Console.WriteLine("Enter your name");
			name= Console.ReadLine();
			Console.WriteLine("Enter your city");
			city= Console.ReadLine();
			Console.WriteLine("Enter your age");
			age = Convert.ToInt32(Console.ReadLine());

			Console.WriteLine("name: {0} || city: {1} || age: {2}", name,city,age);
			Console.ReadLine();



		}
	}
}
