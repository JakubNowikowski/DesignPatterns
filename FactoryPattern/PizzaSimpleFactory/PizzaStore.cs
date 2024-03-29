﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaFactory
{
	public class PizzaStore
	{
		SimplePizzaFactory _factory;

		public PizzaStore(SimplePizzaFactory factory)
		{
			_factory = factory;
		}
		public Pizza OrderPizza(string type)
		{
			Pizza pizza;

			pizza = _factory.CreatePizza(type);
			pizza.Prepare();
			pizza.Bake();

			return pizza;
		}
	}
}
