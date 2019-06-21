using BuilderPattern.CodeBuilderExample;
using BuilderPattern.HtmlBuilderExample;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
	class Program
	{
		static void Main(string[] args)
		{
			//var sb = new StringBuilder();
			//sb.Append("<p>");
			//sb.Append("hello");
			//sb.Append("</p>");

			//var words = new[] { "hello", "world" };
			//sb.Clear();
			//sb.Append("<ul>");

			//foreach (var word in words)
			//{
			//	sb.AppendFormat("<li>{0}</li>", word);
			//}
			//sb.Append("</ul>");
			//Console.WriteLine(sb);

			var builder = new HtmlBuilder("ul");
			builder.AddChild("li", "hello");
			builder.AddChild("li", "world");
			Console.WriteLine(builder);

			//CodeBuilder cb = new CodeBuilder("Person").AddField("Name", "string").AddField("Age", "int").AddField("Height", "float");
			//Console.WriteLine(cb);
			Console.ReadKey();
		}
	}
}
