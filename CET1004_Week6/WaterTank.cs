using System.Reflection.Emit;
using System.Threading.Tasks;

namespace CET1004_Week6
{
	internal class WaterTank
	{
		string location;
		double capacity;
		double currentLevel;
		int updateCount;

		public WaterTank(string _location, double _capacity, double _currentLevel)
		{
			location = _location;
			capacity = _capacity;
			currentLevel = ValidateLevel(_currentLevel);
			updateCount = 1;
		}

		double ValidateLevel(double newLevel)
		{
			if (newLevel < 0 || newLevel > capacity)
			{
				//throw new ArgumentOutOfRangeException("newLevel", "Water level must be between 0 and capacity.");
				Console.WriteLine($"Water level must be between 0 and {capacity} (capacity).");
				return currentLevel;
			}

			Console.WriteLine($"Water level updated successfully to ({newLevel}).");
			updateCount++;
			return newLevel;
		}

		public void SetLocation(string value)
		{
			location = value;
		}

		public string Location
		{
			get { return location; }
			set { location = value; }
		}

		public double Capacity
		{
			get { return capacity; }
		}

		public double CurrentLevel
		{
			get { return currentLevel; }
		}

		public int UpdateCount
		{
			get { return updateCount; }
		}

		public void UpdateLevel(double newLevel)
		{
			currentLevel = ValidateLevel(newLevel);
		}

		public void ShowStatus()
		{
			Console.WriteLine($"Location: {location} | Capacity: {capacity} | Current Level: {currentLevel} | Update Count: {updateCount}");
		}

		public void CheckWarnings()
		{
			if (currentLevel < 0.2 * capacity)
			{
				Console.WriteLine("Warning: Water level is low.");
			}
			else if (currentLevel >= capacity)
			{
				Console.WriteLine("Warning: Water level is overfull.");
			}
			else
			{
				Console.WriteLine("Water level is normal.");
			}
		}
	}
}
