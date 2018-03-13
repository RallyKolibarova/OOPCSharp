using System;
using System.Collections.Generic;

namespace DefineClassPerson
{
	class DefineClassPerson
	{
		public static void Main (string[] args)
		{

			var pesho = new Person ("Pesho", 20);
			var gosho = new Person ("Gosho", 18);
			var stamat = new Person ("Stamat", 43);


			Console.WriteLine (pesho);
			Console.WriteLine (gosho);
			Console.WriteLine (stamat);

	}
}
}
