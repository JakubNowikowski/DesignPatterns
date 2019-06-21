using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IObservableWeather
{
	public class Display1 : IObserver<WeatherData>
	{
		private Sensor _Sensor;
		private float _temperature;
		private float _humidity;
		private float _pressure;
		private IDisposable unsubscriber;

		public virtual void Subscribe(IObservable<WeatherData> provider)
		{
			if (provider != null)
				provider.Subscribe(this);
			Console.WriteLine("+++++++++++++++++++++++++++++++++ Display1 - Subscribing");
		}

		public void OnCompleted()
		{
			throw new NotImplementedException();
		}

		public void OnError(Exception error)
		{
			throw new NotImplementedException();
		}

		public void OnNext(WeatherData weatherData)
		{
			Console.WriteLine("\nDisplay 1 - actual weather conditions\n");

			Console.WriteLine($"Actual Temperature: {weatherData.Temperature}");
			Console.WriteLine($"Actual Humidity: {weatherData.Humidity}");
			Console.WriteLine($"Actual Pressure: {weatherData.Pressure}");
		}

		
	}
}
