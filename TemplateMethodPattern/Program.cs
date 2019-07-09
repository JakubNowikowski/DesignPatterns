using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethodPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            CaffeineBeverage coffee = new Coffee();
            CaffeineBeverage tea = new Tea();

            Console.WriteLine("*** Making coffee");
            coffee.Prepare();

            Console.WriteLine("\n*** Making tea");
            tea.Prepare();

            Console.ReadKey();
        }
    }
}
