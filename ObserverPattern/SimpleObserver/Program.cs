﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObserverPattern.Observers;

namespace ObserverPattern
{
	class Program
	{
		static void Main(string[] args)
		{
			WeatherData weatherData = new WeatherData();
			CurrentConditionsDisplay currentDisplay = new CurrentConditionsDisplay(weatherData);
			ForecastDisplay forecastDisplay = new ForecastDisplay(weatherData);

			weatherData.SetMeasurements(80, 65, 30.4F);
			weatherData.SetMeasurements(82, 70, 29.2F);
			weatherData.SetMeasurements(78, 90, 29.2F);

			Console.ReadKey();
		}
	}
}
