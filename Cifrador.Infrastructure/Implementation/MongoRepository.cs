using Cifrador.Domain.Entity;
using Cifrador.Domain.Repository;
using Cifrador.Infrastructure.InfrastructureService;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace Cifrador.Infrastructure.Implementation
{
    public class MongoRepository<TEntity, TId> : IInitialCharge, IRepository<TEntity, TId>
        where TEntity : Entity<TId>, new()
        where TId : IComparable, IComparable<TId>
    {

        private readonly IMongoCollection<TEntity> mongoCollection;
        private List<TEntity> entities = new List<TEntity>();

        public MongoRepository(string host, string dbName)
        {
            var _client = new MongoClient(host);
            mongoCollection = _client.GetDatabase(dbName).GetCollection<TEntity>(typeof(TEntity).Name);
        }

        public TEntity FindById(string id)
        {
            return entities.FirstOrDefault(it => it.Id.Equals(id));
        }


        public void InitialCharge()
        {
            entities.AddRange(mongoCollection.Find(new BsonDocument()).ToEnumerable());
        }
    }
}
