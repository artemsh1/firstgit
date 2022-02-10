using System;

namespace sym
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("mysym");
			Console.WriteLine(args.Length);
			int sym_1 = Convert.ToInt32(args[0]);
			int sym_2= Convert.ToInt32(args[1]);
			Console.WriteLine(sym_1 + sym_2);
		}
	}
}
