using System;

namespace mass
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Введите длину массива");
			int a = Convert.ToInt32(Console.ReadLine());
			int[] mas = new int[a];
			Random rand = new Random();

			for (int x = 0; x < mas.Length; x++)
			{
				mas[x] = rand.Next(20);
				Console.WriteLine("элемент " + x + " = " + mas[x]);
			}
		}
	}
}
