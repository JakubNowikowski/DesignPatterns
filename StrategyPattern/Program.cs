using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    public class Client
    {
        public IConvertList ConvertListStrategy { get; set; }

        public void Convert(List<string> list)
        {
            if (ConvertListStrategy == null)
                Console.WriteLine("Strategy were not picked");
            else
                PrintList(ConvertListStrategy.Algorithm(list));
        }

        void PrintList(List<string> list)
        {
            foreach (var e in list)
                Console.WriteLine(e);
        }
    }


    public interface IConvertList
    {
        List<string> Algorithm(List<string> list);
    }

    public class ToUpperCase : IConvertList
    {
        public List<string> Algorithm(List<string> list)
        {
            return list.ConvertAll(e => e.ToUpper());
        }
    }

    public class ToLowerCase : IConvertList
    {
        public List<string> Algorithm(List<string> list)
        {
            return list.ConvertAll(e => e.ToLower());
        }
    }



    class Program
    {
        static void Main(string[] args)
        {
            List<string> unsortedList = new List<string> { "lower", "UPPER", "MiXeD" };

            IConvertList toLowerCase = new ToLowerCase();
            IConvertList toUpperCase = new ToUpperCase();

            Client client = new Client();

            Console.WriteLine("Lower case strategy:");

            client.ConvertListStrategy = toLowerCase;

            client.Convert(unsortedList);

            client.ConvertListStrategy = toUpperCase;

            Console.WriteLine("Upper case strategy:");

            client.Convert(unsortedList);

            Console.ReadKey();
        }
    }
}
