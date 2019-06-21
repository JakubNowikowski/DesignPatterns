using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IObservableWeather
{
	public class Display3 : IObserver<WeatherData>
	{
		private Sensor _Sensor;
		private float _temperature;
		private float _humidity;
		private float _pressure;
		private IDisposable unsubscriber;

		private IObservable<WeatherData> _weatherData;

		public Display3(IObservable<WeatherData> weatherData)
		{
			_weatherData = weatherData;
		}

		public virtual void Subscribe(IObservable<WeatherData> provider)
		{
			if (provider != null)
				unsubscriber = provider.Subscribe(this);
			Console.WriteLine("\n+++++++++++++++++++++++++++++++++ Display3 - Subscribing");
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
			Console.WriteLine("\nDisplay 3 - longterm forecast\n");

			Console.WriteLine($"Tomorrow's Temperature: {weatherData.Temperature + 5}");
			Console.WriteLine($"Tomorrow's Humidity: {weatherData.Humidity - 7}");
			Console.WriteLine($"Tomorrow's Pressure: {weatherData.Pressure + 9}");
		}

		public virtual void Unsubscribe()
		{
			Console.WriteLine("------------------------------- Display3 - Unsubscribe");
			unsubscriber.Dispose();
		}

		private bool _isSubscribing = false;

		public bool IsSubscribing
		{
			get { return _isSubscribing; }
			set
			{
				if (!_isSubscribing)
				{
					_isSubscribing = value;
					this.Subscribe(_weatherData);
				}
			}
		}

	}
}
