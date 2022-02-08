using MongoDB.Driver;

namespace FruitData
{
    public class FruitService : IFruitServices
    {

        private readonly IMongoCollection<Fruit> _fruits;

        public FruitService(IDbClient dbClient)
        {
            _fruits = dbClient.GetFruitsCollection();
        }

        public IEnumerable<Fruit> GetFruits() => _fruits.Find(fruit => true).ToList();
    }
}