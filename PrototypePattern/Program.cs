using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace PrototypePattern
{

	#region ICloneable

	//public class Address : ICloneable
	//{
	//	public string StreetName;
	//	public int HouseNumber;

	//	public Address(string streetName, int houseNumber)
	//	{
	//		StreetName = streetName;
	//		HouseNumber = houseNumber;
	//	}

	//	public object Clone()
	//	{
	//		return new Address(StreetName, HouseNumber);
	//	}

	//	public override string ToString()
	//	{
	//		return $"streetName: {StreetName}, houseNumber: {HouseNumber}";
	//	}
	//}

	//public class Person : ICloneable
	//{
	//	public string Name;
	//	public Address Address;

	//	public Person(string name, Address adress)
	//	{
	//		Name = name;
	//		Address = adress;
	//	}

	//	public object Clone()
	//	{
	//		return new Person(Name, (Address)Address.Clone());
	//	}

	//	public override string ToString()
	//	{
	//		return $"Name is {Name} and Adress is {Address}";
	//	}
	//}
	#endregion

	#region Copy Constructors

	//public class Address
	//{
	//	public string StreetName;
	//	public int HouseNumber;

	//	public Address(Address other)
	//	{
	//		StreetName = other.StreetName;
	//		HouseNumber = other.HouseNumber;
	//	}

	//	public Address(string streetName, int houseNumber)
	//	{
	//		StreetName = streetName;
	//		HouseNumber = houseNumber;
	//	}

	//	public override string ToString()
	//	{
	//		return $"streetName: {StreetName}, houseNumber: {HouseNumber}";
	//	}
	//}

	//public class Person
	//{
	//	public string Name;
	//	public Address Address;

	//	public Person(string name, Address adress)
	//	{
	//		Name = name;
	//		Address = adress;
	//	}

	//	public Person(Person other)
	//	{
	//		Name = other.Name;
	//		Address = new Address(other.Address);
	//	}

	//	public override string ToString()
	//	{
	//		return $"Name is {Name} and Adress is {Address}";
	//	}
	//}

	#endregion

	#region Deep Copy Interface

	//public interface IPrototype<T>
	//{
	//	T DeepCopy();
	//}

	//public class Address
	//{
	//	public string StreetName;
	//	public int HouseNumber;

	//	public Address(Address other)
	//	{
	//		StreetName = other.StreetName;
	//		HouseNumber = other.HouseNumber;
	//	}

	//	public Address(string streetName, int houseNumber)
	//	{
	//		StreetName = streetName;
	//		HouseNumber = houseNumber;
	//	}

	//	public override string ToString()
	//	{
	//		return $"streetName: {StreetName}, houseNumber: {HouseNumber}";
	//	}

	//	public Address DeepCopy()
	//	{
	//		return new Address(StreetName, HouseNumber);
	//	}
	//}

	//public class Person:IPrototype<Person>
	//{
	//	public string Name;
	//	public Address Address;

	//	public Person(string name, Address adress)
	//	{
	//		Name = name;
	//		Address = adress;
	//	}

	//	public Person(Person other)
	//	{
	//		Name = other.Name;
	//		Address = new Address(other.Address);
	//	}

	//	public override string ToString()
	//	{
	//		return $"Name is {Name} and Adress is {Address}";
	//	}

	//	public Person DeepCopy()
	//	{
	//		return new Person(Name, Address.DeepCopy());
	//	}
	//}
	#endregion

	#region Serialization

	public static class ExtensionMethods
	{
		public static T DeepCopyBinarySerializer<T>(this T self)
		{
			using (var stream = new MemoryStream())
			{
				var formatter = new BinaryFormatter(); //Serializable attribute
				formatter.Serialize(stream, self);
				stream.Seek(0, SeekOrigin.Begin);
				var copy = formatter.Deserialize(stream);
				stream.Close();
				return (T)copy;
			}
		}

		public static T DeepCopyXMLSerializer<T>(this T self)
		{
			var stream = new MemoryStream();
			var s = new XmlSerializer(typeof(T));
			s.Serialize(stream, self);
			stream.Position = 0;
			return (T)s.Deserialize(stream);
		}

	}

	//[Serializable]
	public class Address
	{
		public string StreetName;
		public int HouseNumber;
		public Address()
		{

		}
		public Address(Address other)
		{
			StreetName = other.StreetName;
			HouseNumber = other.HouseNumber;
		}

		public Address(string streetName, int houseNumber)
		{
			StreetName = streetName;
			HouseNumber = houseNumber;
		}

		public override string ToString()
		{
			return $"streetName: {StreetName}, houseNumber: {HouseNumber}";
		}
	}

	//[Serializable]
	public class Person
	{
		public string Name;
		public Address Address;
		public Person()
		{

		}
		public Person(string name, Address adress)
		{
			Name = name;
			Address = adress;
		}

		public Person(Person other)
		{
			Name = other.Name;
			Address = new Address(other.Address);
		}

		public override string ToString()
		{
			return $"Name is {Name} and Adress is {Address}";
		}
	}
	#endregion

	
	class Program
	{
		static void Main(string[] args)
		{
			////ICloneable

			//Person person = new Person("Tom", new Address("xd", 13));
			//Person newPerson = (Person)person.Clone();
			//newPerson.Address.HouseNumber = 11;

			////Copy Constructor

			//Person person = new Person("Tom", new Address("xd", 13));
			//Person newPerson = new Person(person);
			//newPerson.Address.HouseNumber = 11;

			////Deep Copy Interface

			//Person person = new Person("Tom", new Address("xd", 13));
			//Person newPerson = person.DeepCopy();
			//newPerson.Address.HouseNumber = 11;

			////Serialization

			Person person = new Person("Tom", new Address("xd", 13));
			//Person newPerson = person.DeepCopyBinarySerializer();
			Person newPerson = person.DeepCopyXMLSerializer();
			newPerson.Address.HouseNumber = 11;

			Console.WriteLine(person);
			Console.WriteLine(newPerson);

			Console.ReadKey();
		}

		//static void Main(string[] args)
		//{
		//	Line line = new Line() { Start = new Point(0, 0), End = new Point(10, 10) };

		//	Line newLine = line.DeepCopy();

		//	newLine.End.X = 20;
		//	newLine.End.Y= 20;

		//	Console.WriteLine(line);
		//	Console.WriteLine(newLine);

		//	Console.ReadKey();
		//}
	}
}
