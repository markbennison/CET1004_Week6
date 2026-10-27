using System.Reflection;

namespace CET1004_Week6
{
	internal class Menus
	{
		public static int GetMainMenuOption()
		{
			Console.Clear();
			Console.ForegroundColor = ConsoleColor.Yellow;
			Console.WriteLine("{0} \n\n", Assembly.GetCallingAssembly().GetName().Name);
			Console.ForegroundColor = ConsoleColor.White;

			Console.WriteLine("(1) Exercise 1: Smart Lamp");
			Console.WriteLine("(2) Exercise 2");
			Console.WriteLine("(3) Exercise 3");
			Console.WriteLine("(4) Exercise 4");
			Console.WriteLine("(5) Exercise 5");

			Console.WriteLine("(0) Exit");

			int input = Convert.ToInt32(Console.ReadLine());

			return input;
		}

	}
}
