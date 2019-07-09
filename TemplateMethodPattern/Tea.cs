using System;

namespace TemplateMethodPattern
{
    class Tea : CaffeineBeverage
    {
        public override void Brew()
        {
            Console.WriteLine("Stepping the tea");
        }

        public override void AddCondiments()
        {
            Console.WriteLine("Adding lemon");
        }
    }
}
