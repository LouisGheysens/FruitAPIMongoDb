using Microsoft.Extensions.Options;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FruitData
{
    public class DbClient : IDbClient
    {
        //Setup data acces monogdb
        private readonly IMongoCollection<Fruit> _fruits;

        public DbClient(IOptions<FruitstoreDBConfig> fruitstoreDbConfig)
        {
            var client = new MongoClient(fruitstoreDbConfig.Value.Connection_String);
            var db = client.GetDatabase(fruitstoreDbConfig.Value.Database_Name);
            _fruits = db.GetCollection<Fruit>(fruitstoreDbConfig.Value.Fruits_Colllection_Name);
        }

        public IMongoCollection<Fruit> GetFruitsCollection() => _fruits;
    }
}
