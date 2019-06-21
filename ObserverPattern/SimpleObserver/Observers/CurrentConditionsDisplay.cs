using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern.Observers
{
	public class CurrentConditionsDisplay : IObserver, IDisplayElement
	{
		private float _temperture;
		private float _humidity;
		private ISubject _weatherData;

		public CurrentConditionsDisplay(ISubject weatherData)
		{
			_weatherData = weatherData;
			_weatherData.RegisterObserver(this);
		}

		public void Update(float temperature, float humidity, float pressure)
		{
			_temperture = temperature;
			_humidity = humidity;
			Display();
		}

		public void Display()
		{
			Console.WriteLine("Current conditions: "+_temperture + "F degrees and "+_humidity+"% humidity");
		}
	}
}
