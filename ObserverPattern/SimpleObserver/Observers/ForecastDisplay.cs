using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern.Observers
{
	public class ForecastDisplay : IObserver, IDisplayElement
	{
		private float currentPressure = 29.92f;
		private float lastPressure;
		private WeatherData _weatherData;

		public ForecastDisplay(WeatherData weatherData)
		{
			_weatherData = weatherData;
			weatherData.RegisterObserver(this);
		}

		public void Update(float temp, float humidity, float pressure)
		{
			lastPressure = currentPressure;
			currentPressure = pressure;

			Display();
		}

		public void Display()
		{
			Console.WriteLine("Forecast: ");
			if (currentPressure > lastPressure)
			{
				Console.WriteLine("Improving weather on the way!");
			}
			else if (currentPressure == lastPressure)
			{
				Console.WriteLine("More of the same");
			}
			else if (currentPressure < lastPressure)
			{
				Console.WriteLine("Watch out for cooler, rainy weather");
			}
		}
	}


}
