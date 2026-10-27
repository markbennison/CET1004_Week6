namespace CET1004_Week6
{
	internal class SmartLamp
	{
		bool isOn = false;
		int brightness = 100;
		ConsoleColor color = ConsoleColor.White;

		public SmartLamp()
		{
			isOn = false;
			brightness = 100;
			color = ConsoleColor.White;
		}

		public SmartLamp(bool _isOn, int _brightness, ConsoleColor _color)
		{
			isOn = _isOn;
			Brightness = _brightness;
			color = _color;
		}

		public bool IsOn
		{
			get { return isOn; }
		}

		public void SetBrightness(int value)
		{
			if (value >= 0 && value <= 100)
			{
				brightness = value;
			}
			else
			{
				Console.WriteLine("Brightness must be between 0 and 100.");
			}
		}

		public int Brightness
		{
			get { return brightness; }
			set
			{
				if (value >= 0 && value <= 100)
				{
					brightness = value;
				}
				else
				{
					Console.WriteLine("Brightness must be between 0 and 100.");
				}
			}
		}

		public ConsoleColor Color
		{
			get { return color; }
			set { color = value; }
		}
		
		public void TurnOn()
		{
			isOn = true;
		}

		public void TurnOff()
		{
			isOn = false;
		}

		public void ShowStatus()
		{
			Console.ForegroundColor = ConsoleColor.White;
			Console.Write($"Lamp is {(isOn ? "On" : "Off")}, Brightness: {brightness}, Color: ");
			Console.ForegroundColor = color;
			Console.WriteLine(color);
			Console.ForegroundColor = ConsoleColor.White;

			//Console.ForegroundColor = color;
			//Console.WriteLine($"Lamp is {(isOn ? "On" : "Off")}, Brightness: {brightness}, Color: {color}");
			//Console.ForegroundColor = ConsoleColor.White;
		}

	}
}
