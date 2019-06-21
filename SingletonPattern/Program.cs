using MoreLinq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
	class Program
	{
		public interface IDatabase
		{
			int GetPopulation(string name);
		}

		public class SingletonDatabase : IDatabase
		{
			private Dictionary<string, int> capitals;

			private SingletonDatabase()
			{
				Console.WriteLine("Initializing db");

				capitals = File.ReadAllLines("Capitals.txt")
					.Batch(2)
					.ToDictionary(
					list => list.ElementAt(0).Trim(),
					list => int.Parse(list.ElementAt(1))
					);
			}

			public int GetPopulation(string name)
			{
				return capitals[name];
			}

			private static Lazy<SingletonDatabase> instance = new Lazy<SingletonDatabase>(()=>new SingletonDatabase());

			public static SingletonDatabase Instance=> instance.Value;
		}

		[TestFixture]
		public class SingletonTests
		{
			[Test]
			public void IsSingletonTest()
			{
				var db = SingletonDatabase.Instance;
				var db2 = SingletonDatabase.Instance;

				Assert.That(db, Is.SameAs(db2));
			}
		}

		static void Main(string[] args)
		{
			var db = SingletonDatabase.Instance;
			var db2 = SingletonDatabase.Instance;


			var city = "Tokyo";

			Console.WriteLine($"{city} has population {db.GetPopulation(city)}");

			Console.ReadKey();
		}
	}
}
