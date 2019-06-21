using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern.CodeBuilderExample
{
	public class CodeBuilder
	{
		CodeElement root = new CodeElement();

		public CodeBuilder(string className)
		{
			root.ClassName = className;
		}
		
		public CodeBuilder AddField(string fieldName, string fieldType)
		{
			var e = new CodeElement(fieldName, fieldType);
			root.elements.Add(e);
			return this;
		}

		public override string ToString()
		{
			return root.ToString();
		}
	}
}
