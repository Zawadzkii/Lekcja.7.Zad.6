using System;

class Program
{
	static void Main(string[] args)
	{
		Console.WriteLine("Podaj swój wzrost (w centymetrach):");
		int wzrost = Convert.ToInt32(Console.ReadLine());

		if (wzrost < 150)
		{
			Console.WriteLine("Jesteś krasnoludem");
		}
		else if (wzrost >= 150 && wzrost < 165)
		{
			Console.WriteLine("Jesteś średniego wzrostu");
		}
		else if (wzrost >= 165 && wzrost < 180)
		{
			Console.WriteLine("Jesteś wysokiego wzrostu");
		}
		else
		{
			Console.WriteLine("Jesteś bardzo wysokiego wzrostu");
		}
	}
}