using PizzaFactory;
using PizzaFactory.PizzaStores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaAbstractFactory
{
	class Program
	{
		static void Main(string[] args)
		{
			//SimplePizzaFactory pizzaFactory = new SimplePizzaFactory();

			//PizzaStore pizzaStore = new PizzaStore(pizzaFactory);

			PizzaStore nyStore = new NYPizzaStore();

			string pizzaType = Console.ReadLine();

			nyStore.OrderPizza(pizzaType);

			

			Console.ReadKey();
		}
	}
}
