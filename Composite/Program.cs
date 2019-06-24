using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    class Program
    {
        public class GeometricObject
        {
            public virtual string Name { get; set; }
            public string Color;
            public Coordinates Coordinates;
            private Lazy<List<GeometricObject>> childrenShapes = new Lazy<List<GeometricObject>>();
            public List<GeometricObject> Children => childrenShapes.Value;

            private void Print(StringBuilder sb, int depth)
            {
                sb.Append(string.Concat(Enumerable.Repeat("--> ", depth)))
                .Append(string.IsNullOrWhiteSpace(Color) ? string.Empty : $"{Color} ")
                .Append(Name)
                .AppendLine($" {Coordinates}");
                foreach (var child in Children)
                {
                    child.Print(sb, depth + 1);
                }
            }

            public override string ToString()
            {
                var sb = new StringBuilder();
                Print(sb, 0);
                return sb.ToString();
            }
        }

        public class Circle : GeometricObject
        {
            public override string Name => "Circle";
        }

        public class Line : GeometricObject
        {
            public override string Name => "Line";
        }

        public class Coordinates
        {
            private int X, Y;

            public Coordinates(int x, int y)
            {
                X = x;
                Y = y;
            }

            public override string ToString()
            {
                return $"{{{X}, {Y}}}";
            }
        }

        static void Main(string[] args)
        {
            var drawing = new GeometricObject() { Name = "Drawing with circles and rectangle" };
            drawing.Children.Add(new Circle() { Color = "Red", Coordinates = new Coordinates(1, 1) });

            var rectangle = new GeometricObject() { Name = "Green rectangle" };
            rectangle.Children.Add(new Line() { Color = "Green", Coordinates = new Coordinates(20, 20) });
            rectangle.Children.Add(new Line() { Color = "Green", Coordinates = new Coordinates(20, 30) });
            rectangle.Children.Add(new Line() { Color = "Green", Coordinates = new Coordinates(30, 30) });
            rectangle.Children.Add(new Line() { Color = "Green", Coordinates = new Coordinates(30, 20) });
            drawing.Children.Add(rectangle);

            drawing.Children.Add(new Circle() { Color = "Blue", Coordinates = new Coordinates(13, 15) });

            Console.WriteLine(drawing);

            Console.ReadKey();
        }
    }
}
