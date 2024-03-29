﻿using System;
using System.Collections.Generic;

namespace IObservableWeather
{
	internal class Unsubscriber : IDisposable
	{
		private List<IObserver<WeatherData>> _observers;
		private IObserver<WeatherData> _observer;

		public Unsubscriber(List<IObserver<WeatherData>> observers, IObserver<WeatherData> observer)
		{
			_observers = observers;
			_observer = observer;
		}

		public void Dispose()
		{
			if (_observer != null && _observers.Contains(_observer))
				_observers.Remove(_observer);
		}
	}
}