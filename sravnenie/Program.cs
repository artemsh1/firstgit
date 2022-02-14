using System;

namespace sravnenie
{
	class Program
	{
		static void Main(string[] args)
		{
			int ch1, ch2;
			ch1 = Convert.ToInt32(Console.ReadLine());
			ch2 = Convert.ToInt32(Console.ReadLine());
			if (GetCompasion(ch1, ch2))
			{
				Console.WriteLine("Цифр больше в 1 числе");
			}
			else if (GetCompasion(ch1, ch2)) 
			{
				Console.WriteLine("Цифр больше в 2 числе");
			}
			else
			{
				Console.WriteLine("одинаковы ");
			}
		}
		static bool GetCompasion(int ch1, int ch2)
		{
		while (ch1 > 0 && ch2> 0)
			{
			ch1 = ch1 / 10;
			ch2 = ch2 / 10;

	}
	if (ch1 > ch2)
		return true;
		return false;

}
static bool GetCompasionn(int ch1, int ch2)
{
	while (ch1>0 && ch2>0)
	{
		ch1 = ch1 / 10;
		ch2 = ch2 / 10;
	}
	if (ch1 < ch2)
		return true;
	return false;
}
}
}  
