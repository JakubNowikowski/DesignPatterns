using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
	public interface IBeverage
	{
		float Cost();
		string AsString();
	}

	#region Components

	public class Espresso : IBeverage
	{
		public string AsString()
		{
			return "Espresso";
		}

		public float Cost()
		{
			return 2.10f;
		}
	}
	public class Cappucino : IBeverage
	{
		public string AsString()
		{
			return "Cappucino";
		}

		public float Cost()
		{
			return 2.30f;
		}
	}

	#endregion

	#region Decorators
	public class WithMilk : IBeverage
	{
		private IBeverage beverage;

		public WithMilk(IBeverage beverage)
		{
			this.beverage = beverage;
		}

		public string AsString()
		{
			return $"{beverage.AsString()} + milk";
		}

		public float Cost()
		{
			return beverage.Cost() + .10f;
		}
	}

	public class WithSugar : IBeverage
	{
		private IBeverage beverage;

		public WithSugar(IBeverage beverage)
		{
			this.beverage = beverage;
		}

		public string AsString()
		{
			return $"{beverage.AsString()} + sugar";
		}

		public float Cost()
		{
			return beverage.Cost() + .20f;
		}
	}

	#endregion

	class Program
	{
		static void Main(string[] args)
		{
			var espresso = new Espresso();

			Console.WriteLine($"{espresso.AsString()} costs {espresso.Cost()} $");

			var espressoWithMilk = new WithMilk(espresso);

			Console.WriteLine($"{espressoWithMilk.AsString()} costs {espressoWithMilk.Cost()} $");

			var espressoWithMilkAndSugar = new WithSugar(espressoWithMilk);

			Console.WriteLine($"{espressoWithMilkAndSugar.AsString()} costs {espressoWithMilkAndSugar.Cost()} $");

			Console.ReadKey();
		}
	}
}
