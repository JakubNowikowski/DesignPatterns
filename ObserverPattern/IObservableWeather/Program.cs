using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IObservableWeather
{
	class Program
	{
		static void Main(string[] args)
		{
			int temperature = 20;
			int humidity = 0;
			int pressure = 0;
			
			Random r = new Random();

			string input;
			string[] parameters = new string[3];

			Sensor sensor = new Sensor();
			Display1 display1 = new Display1();
			Display2 display2 = new Display2();
			Display3 display3 = new Display3(sensor);

			display1.Subscribe(sensor);
			display2.Subscribe(sensor);

			//Console.WriteLine("\nSet new weather parameters (temperature/humidity/pressure):\n");

			//input = Console.ReadLine();
			//parameters = input.Split(' ');

			//temperature = Convert.ToInt32(parameters[0]);
			//humidity = Convert.ToInt32(parameters[1]);
			//pressure = Convert.ToInt32(parameters[2]);

			//if (temperature > 50)
			//	display2.Unsubscribe();

			//if (temperature < 10)
			//	display2.Subscribe(sensor);

			Init();

			Console.ReadKey();

			async Task Init()
			{
				await Task.Run(() =>
				{
					while (true)
					{
						System.Threading.Thread.Sleep(2000);
						humidity = r.Next(15, 30);
						pressure = r.Next(990, 1020);
						Console.WriteLine("\n``````````````````````" + DateTime.Now + "``````````````````````\n");

						temperature += 1;

						if (temperature >= 25 && temperature < 30)
						{
							display2.IsSubscribing = false;
						}
						else if (temperature >= 30)
						{
							display3.IsSubscribing = true; //metoda
						}

						sensor.MakeNewMeasurement(new WeatherData(temperature, humidity, pressure));
					}
				});
			}
		}
	}
}

