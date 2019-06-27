using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    public interface IBookshop
    {
        void TakeOrder(string order);
        void DeliverOrder();
        void Payment(int price);
    }

    class Bookshop : IBookshop
    {
        private string _order;
        public void TakeOrder(string order)
        {
            _order = order;
            Console.WriteLine($"Shop assistant takes order for '{_order}'");
        }

        public void DeliverOrder()
        {
            Console.WriteLine($"Shop assistant delivers '{_order}'");
        }

        public void Payment(int price)
        {
            Console.WriteLine($"Order costs {price}. Client can pay cash or by card");
        }
    }

    class NewProxyBookshop : IBookshop
    {
        private string _order;
        Bookshop orgBookshop = new Bookshop();

        public void TakeOrder(string order)
        {
            _order = order;
            Console.WriteLine($"Client selects on the machine book his order - '{_order}'");
        }

        public void DeliverOrder()
        {
            Console.WriteLine("Machine book gives chosen book for the client");
        }

        public void Payment(int price)
        {
            Console.WriteLine("Client pays for the order using terminal in the machine");
            orgBookshop.Payment(price);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            IBookshop bookshop = new Bookshop();
            bookshop.TakeOrder("Star wars");
            bookshop.DeliverOrder();
            bookshop.Payment(50);

            Console.WriteLine();

            IBookshop modernBookshop = new NewProxyBookshop();
            modernBookshop.TakeOrder("Star wars");
            modernBookshop.DeliverOrder();
            modernBookshop.Payment(50);

            Console.ReadKey();
        }
    }
}
