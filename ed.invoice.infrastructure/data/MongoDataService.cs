using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ed.invoice.domain;
using MongoDB.Driver;

namespace ed.invoice.infrastructure.data
{
    public class MongoDataService : IDataService
    {
        MongoDB.Driver.IMongoClient client;

        public MongoDataService()
        {
            // MongoClientSettings.FromUrl)
            client = new MongoClient("mongodb://localhost:27017");
            var database = client.GetDatabase("eos_invoice");

            this.Customers = database.GetCollection<Customer>(nameof( Customer) ).AsQueryable();
            this.Items = database.GetCollection<Item>(nameof( Item) ).AsQueryable();
        }
        public IQueryable<Customer> Customers { get; private set; }

        public IQueryable<Item> Items { get; private set; }
    }
}
