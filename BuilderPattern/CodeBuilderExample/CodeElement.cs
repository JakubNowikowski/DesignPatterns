using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern.CodeBuilderExample
{
	public class CodeElement
	{
		public string ClassName, FieldType, FieldName;
		StringBuilder sb = new StringBuilder();
		public List<CodeElement> elements = new List<CodeElement>();

		public CodeElement()
		{

		}

		public CodeElement(string name, string type)
		{
			FieldName = name;
			FieldType = type;
		}

		private string ToStringImpl()
		{
			sb.AppendLine($"public class {ClassName}");
			sb.AppendLine("{");
			AddFields(0);
			sb.AppendLine("}");

			return sb.ToString();
		}

		private string AddFields(int indent)
		{
			const int indentSize = 1;
			var i = new string(' ', indent * indentSize);

			if (!string.IsNullOrWhiteSpace(FieldType))
			{
				sb.Append(new string(' ', indentSize * (indent + 1)));
				sb.AppendLine($"public {FieldType} {FieldName};");
			}

			foreach (var e in elements)
			{
				sb.Append(e.AddFields(indent + 1));
			}

			return sb.ToString();
		}

		public override string ToString()
		{
			return ToStringImpl();
		}
	}

}
