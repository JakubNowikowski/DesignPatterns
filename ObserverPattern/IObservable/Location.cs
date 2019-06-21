using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IObservable
{
	public struct Location
	{
		private double _latitude, _longitude;

		public Location(double latitude, double longitude)
		{
			_latitude = latitude;
			_longitude = longitude;
		}

		public double Latitude => _latitude;

		public double Longitude => _longitude;
	}
}
