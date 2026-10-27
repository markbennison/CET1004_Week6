namespace CET1004_Week6
{
	internal class Program
	{

		static void Main(string[] args)
		{
			int menuOption;

			do
			{
				menuOption = Menus.GetMainMenuOption();

				switch (menuOption)
				{
					case 1:
						ExerciseOne();
						break;
					case 2:
						ExerciseTwo();
						break;
				}
			} while (menuOption > 0);
		}

		static void ExerciseOne()
		{
			Console.Clear();
			SmartLamp lamp = new SmartLamp();
			lamp.ShowStatus();
			lamp.TurnOn();
			lamp.Brightness = 75;
			lamp.Color = ConsoleColor.Blue;
			lamp.ShowStatus();

			lamp.Color = ConsoleColor.Red;
			lamp.ShowStatus();

			Console.ReadKey();
		}

		static void ExerciseTwo()
		{
			Console.Clear();

			WaterTank waterTank = new WaterTank("Here", 1000, 500);

			/*
			

7. In your Main() method:
a. Create a WaterTankMonitor object with a realistic
capacity and initial water level (currentLevel). Hint :
use the constructor.
b. Display its status (use ShowStatus()).
c. Call UpdateLevel(double newLevel) several times
with different newLevel values for the different cases
(normal, low, and overfull).
i. After each update, call ShowStatus() and
CheckWarnings() to observe the output (normal, low, and overfull).
Extension (optional):
Add a method Drain(double amount) that decreases the currentLevel by a specified amount,
ensuring the value never becomes negative. Test the method in the Main().

*/


		}
	}
}
