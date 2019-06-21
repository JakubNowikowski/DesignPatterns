using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
	public class WeatherData : ISubject
	{
		private List<IObserver> observers;
		private float _temperature;
		private float _humidity;
		private float _pressure;

		public WeatherData()
		{
			observers = new List<IObserver>();
		}

		public void RegisterObserver(IObserver o)
		{
			observers.Add(o);
		}

		public void RemoveObserver(IObserver o)
		{
			int i = observers.IndexOf(o);
			if (i >= 0)
				observers.Remove(o);
		}
		public void NotifyObservers()
		{
			foreach (IObserver o in observers)
				o.Update(_temperature, _humidity, _pressure);
		}

		public void MeasurementChanged()
		{
			NotifyObservers();
		}

		public void SetMeasurements(float temperature, float humidity, float pressure)
		{
			_temperature = temperature;
			_humidity = humidity;
			_pressure = pressure;
			MeasurementChanged();
		}

	}
}
