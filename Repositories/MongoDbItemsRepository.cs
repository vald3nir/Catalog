using System;
using System.Collections.Generic;
using System.Linq;
using Catalog.Entities;
using MongoDB.Driver;

namespace Catalog.Repositories
{
    /*
        setup: 
        dotnet add package MongoDB.Driver --version 2.13.1 

        docker pull tutum/mongodb
        docker run -d -p 27017:27017 -p 28017:28017 -e AUTH=no tutum/mongodb // criação sem senha
        docker ps -a
    */

    public class MongoDbItemsRepository : IItemsRepository
    {
        private const string databaseName = "catalog";
        private const string collectionName = "items";
        private readonly IMongoCollection<Item> itemsCollection;

        public MongoDbItemsRepository(IMongoClient mongoClient)
        {
            IMongoDatabase database = mongoClient.GetDatabase(databaseName);
            itemsCollection = database.GetCollection<Item>(collectionName);
        }

        public IEnumerable<Item> GetItems()
        {
            return null;
        }

        public Item GetItem(Guid id)
        {
            return null;
        }

        public void CreateItem(Item item)
        {
            itemsCollection.InsertOne(item);
        }

        public void UpdateItem(Item item)
        {
        }

        public void DeleteItem(Guid id)
        {
            // var index = items.FindIndex(existingItem => existingItem.Id == id);
            // items.RemoveAt(index);
        }
    }
}