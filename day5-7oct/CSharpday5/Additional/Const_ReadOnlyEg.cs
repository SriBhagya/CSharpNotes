using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Additional
{
	class Constg
	{
		//compile time constant
		public const float pi = 3.14f;
		const int value = 10 + 20;
		//non constant variable
		/*int data = 80;
		error*/
		//const int add = 10 + data;
		//static const int value1 = 10 + 20;
		internal void PerimeterofCircle(int radius)
		{
			//const string name = "JAI";
			//PI=89.0;
			//ERROR
			Console.WriteLine("PerimeterofCircle:{0}", (2 * pi * radius));

		}
	}
	class ReadonlyEg
	{
		//Rum time constant
		internal readonly string SchoolName;
		internal static readonly string OrgName = "l&t";
		internal ReadonlyEg(string SchoolName)
		{
			this.SchoolName = SchoolName;

		}

		void DisplayStudent()
		{
			//Error
			//SchoolName="mn";

		}
	}

	class Const_ReadOnlyEg
	{
		static void Main()
		{
			ReadonlyEg readonlyEg = new ReadonlyEg("ZAIN");
			ReadonlyEg r2 = new ReadonlyEg("KV");
			Constg c = new Constg();
			c.PerimeterofCircle(4);
			Console.ReadLine();

		}
	}
}
