using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SingletonVsStaticClass
{
    class SomeClass
    {
        public int ABC;
    }

    public sealed class SingletonSampleClass
    {
        static SingletonSampleClass _instance;

        public static SingletonSampleClass Instance
        {
            get { return _instance ?? (_instance = new SingletonSampleClass()); }
        }
        private SingletonSampleClass() { }

        public string Message { get; set; }
    }

    static public class StaticSampleClass
    {
        private static readonly int SomeVariable;
        //Static constructor is executed only once when the type is first used.   
        //All classes can have static constructors, not just static classes.  
        static StaticSampleClass()
        {
            SomeVariable = 1;
            //Do the required things  
        }
        public static string ShowValue()
        {
            return string.Format("The value of someVariable is {0}", SomeVariable);
        }
        public static string Message { get; set; }
    }
    class Program
    {

        static void Main(string[] args)
        {
            //Normal class instantiation and usage  
            var someClass = new SomeClass { ABC = 5 };
            Console.WriteLine("Normal class usage: " + someClass.ABC);

            //Static Class instantiation  
            string returnValue = StaticSampleClass.ShowValue();
            Console.WriteLine("Static class usage: " + returnValue);

            //Singleton class instantiation  
            var singletonSampleClass = SingletonSampleClass.Instance;
            singletonSampleClass.Message = "Hello";
            Console.WriteLine("Singleton class usage: " + singletonSampleClass.Message);

            //Test the instances if are equal  
            var anotherSingletonSampleClass = SingletonSampleClass.Instance;
            Console.WriteLine("Checking if both instances are same: " + singletonSampleClass.Equals(anotherSingletonSampleClass));

            Console.Read();
        }
    }
}