using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IObservableWeather
{
	public class Display2 : IObserver<WeatherData>
	{
		private Sensor _Sensor;
		private float _temperature;
		private float _humidity;
		private float _pressure;
		private IDisposable unsubscriber;

		public virtual void Subscribe(IObservable<WeatherData> provider)
		{
			if (provider != null)
				unsubscriber = provider.Subscribe(this);
			Console.WriteLine("\n+++++++++++++++++++++++++++++++++ Display2 - Subscribing");
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
			Console.WriteLine("\nDisplay 2 - forecast\n");

			Console.WriteLine($"Tomorrow's Temperature: {weatherData.Temperature + 2}");
			Console.WriteLine($"Tomorrow's Humidity: {weatherData.Humidity - 5}");
			Console.WriteLine($"Tomorrow's Pressure: {weatherData.Pressure + 7}");
		}

		public virtual void Unsubscribe()
		{
			Console.WriteLine("------------------------------- Display2 - Unsubscribe");
 			unsubscriber.Dispose();
		}

		private bool _isSubscribing = true;
		public bool IsSubscribing
		{
			get { return _isSubscribing; }
			set
			{
				if (_isSubscribing != value)
				{
					_isSubscribing = value;
					this.Unsubscribe();
				}
			}
		}
	}
}
