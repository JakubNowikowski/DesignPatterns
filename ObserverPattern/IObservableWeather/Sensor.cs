using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IObservableWeather
{
	public class Sensor : IObservable<WeatherData>
	{
		private List<IObserver<WeatherData>> observers;
		private WeatherData _weatherData;

		public Sensor()
		{
			observers = new List<IObserver<WeatherData>>();
		}

		public IDisposable Subscribe(IObserver<WeatherData> observer)
		{
			observers.Add(observer);
			return new Unsubscriber(observers, observer);
		}

		public void MeasurementChanged()
		{
			foreach (IObserver<WeatherData> observer in observers)
				observer.OnNext(_weatherData); 
		}

		public void MakeNewMeasurement(WeatherData weatherData)
		{
			_weatherData = weatherData;
			MeasurementChanged();
		}
	}
}
