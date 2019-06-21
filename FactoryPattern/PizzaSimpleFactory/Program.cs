using PizzaFactory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaSimpleFactory
{
	class Program
	{
		static void Main(string[] args)
		{
			SimplePizzaFactory pizzaFactory = new SimplePizzaFactory();

			PizzaStore pizzaStore = new PizzaStore(pizzaFactory);

			string input = Console.ReadLine();

			pizzaStore.OrderPizza(input);

			Console.ReadKey();


		}
	}
}
