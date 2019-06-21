using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IObservable
{

	public class LocationReporter : IObserver<Location>
	{
		private IDisposable unsubscriber;
		private string _name;

		public LocationReporter(string name)
		{
			_name = name;
		}

		public string Name => _name;

		public virtual void Subscribe(IObservable<Location> provider)
		{
			if (provider != null)
				unsubscriber = provider.Subscribe(this);
		}

		public virtual void OnCompleted()
		{
			Console.WriteLine("The Location Tracker has completed transmitting data to {0}.", Name);
			Unsubscribe();
		}

		public virtual void OnError(Exception e)
		{
			Console.WriteLine("{0}: The location cannot be determined.", Name);
		}

		public virtual void OnNext(Location value)
		{
			Console.WriteLine("{2}: The current location is {0}, {1}", value.Latitude, value.Longitude, Name);
		}

		public virtual void Unsubscribe()
		{
			unsubscriber.Dispose();
		}
	}
}
