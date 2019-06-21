using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reactive.Linq;


namespace IObservableWeather
{
	public class WeatherData 
	{
		float _temperature, _humidity, _pressure;

		public WeatherData(float temperature, float humidity, float pressure)
		{
			_temperature = temperature;
			_humidity = humidity;
			_pressure = pressure;
		}

		public float Temperature { get => _temperature; }
		public float Humidity { get => _humidity; }
		public float Pressure { get => _pressure; }
	}
}
