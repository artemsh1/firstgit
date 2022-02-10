using System;

namespace git
{
	class MyHello
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");
			String name;
			name = Console.ReadLine();
			Console.WriteLine($"Привет, {name}");
		}
	}
}
