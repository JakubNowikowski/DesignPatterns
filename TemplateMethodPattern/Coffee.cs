using System;

namespace TemplateMethodPattern
{
    class Coffee : CaffeineBeverage
    {
        public override void Brew()
        {
            Console.WriteLine("Brewing coffee grinds");
        }

        public override void AddCondiments()
        {
            Console.WriteLine("Adding sugar and milk");
        }
    }
}
