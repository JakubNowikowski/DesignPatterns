using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    public interface ISqlDataBase
    {
        void SendDataToSqlDb();
    }

    class SqlDataBaseService : ISqlDataBase
    {
        public void SendDataToSqlDb()
        {
            Console.WriteLine("Sending data to Sql DataBase");
        }
    }

    public interface IMongoDataBase
    {
        void SendDataToMongoDb();
    }

    class MongoDataBaseService : IMongoDataBase
    {
        public void SendDataToMongoDb()
        {
            Console.WriteLine("Sending data to Mongo DataBase");
        }
    }

    class MongoDataBaseServiceAdapter : ISqlDataBase
    {
        IMongoDataBase _mongoDataBase;

        public MongoDataBaseServiceAdapter(IMongoDataBase mongoDataBase)
        {
            _mongoDataBase = mongoDataBase;
        }

        public void SendDataToSqlDb()
        {
            _mongoDataBase.SendDataToMongoDb();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sending data to Sql DataBase by SqlDataBaseService:");
            SqlDataBaseService sqlDataBase = new SqlDataBaseService();
            sqlDataBase.SendDataToSqlDb();

            Console.WriteLine("\nSending data to Mongo DataBase by MongoDataBaseService:");
            MongoDataBaseService mongoDataBase = new MongoDataBaseService();
            mongoDataBase.SendDataToMongoDb();

            Console.WriteLine("\nSending data to Sql DataBase by MongoDataBaseService using MongoDataBase Adapter:");
            ISqlDataBase mongoDataBaseAdapter = new MongoDataBaseServiceAdapter(mongoDataBase);
            mongoDataBase.SendDataToMongoDb();

            Console.ReadKey();
        }
    }
}
