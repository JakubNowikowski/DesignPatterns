using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypePattern
{
	public class Point
	{
		public int X, Y;

		public Point(int x, int y)
		{
			X = x;
			Y = y;
		}
	}

	public class Line
	{
		public Point Start, End;

		public Line DeepCopy()
		{
			return new Line()
			{
				Start = new Point(Start.X, Start.Y),
				End = new Point(End.X, End.Y)
			};
		}

		public override string ToString()
		{
			return $"StartPoint: [{Start.X},{Start.Y}] EndPoint: [{End.X},{End.Y}]";
		}
	}
}