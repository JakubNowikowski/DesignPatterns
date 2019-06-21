using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IObservable
{
	class Class1
	{
		public Class1(IEnumerable<Func<char, char>> transformations)
		{
			this.transformations = transformations;
		}

		private readonly IEnumerable<Func<char, char>> transformations;

		public string LetterChanges(string str)
		{
			IEnumerable<char> result = str.ToArray().AsParallel();
			foreach (var transformation in transformations)
			{
				result = result.Select(transformation);
			}
			return new string(result.ToArray());
		}
	}
	public interface ITransformation
	{
		char Transform(char input);
	}

	//class Program2
	//{

	//	static void Main(string[] args)
	//	{
	//		char[] vowels = new[] { 'a', 'e', 'i', 'o', 'u' };
	//		char IncrementLetter(char c)
	//		{
	//			if (c >= 'a' && c <= 'z')
	//			{
	//				if (c == 'z')
	//					return 'a';
	//				return (char)(c + 1);
	//			}
	//			return c;
	//		}

	//		char SetToUpperIfVowel(char c)
	//		{
	//			if (vowels.Contains(c))
	//				return char.ToUpper(c);
	//			return c;
	//		}
	//		Action<char, char> myFunc = (char a, char b) => { var xd = 'c'; };

	//		IEnumerable<Func<char, char>> transformations = new Func<char, char>[] { SetToUpperIfVowel };
	//		var myClass = new Class1(transformations);
	//		Console.WriteLine(myClass.LetterChanges("hello*3"));
	//		Console.ReadKey();
	//	}
	//}
	class Transformers1 : ITransformation
	{
		public char Transform(char c)
		{
			if (c >= 'a' && c <= 'z')
			{
				if (c == 'z')
					return 'a';
				return (char)(c + 1);
			}
			return c;
		}
	}
}
