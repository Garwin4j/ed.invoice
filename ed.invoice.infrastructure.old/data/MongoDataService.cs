using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ed.invoice.domain;
using MongoDB.Driver;
using System.Configuration;
using MongoRepository;

namespace ed.invoice.infrastructure.data
{
    public class MongoDataService : IDataService
    {

        public MongoDataService()
        {

            var connectionString = ConfigurationManager.ConnectionStrings["DataService"].ConnectionString;
            var connectionUrl = MongoUrl.Create(connectionString);

            this.Customers = new MongoRepository.MongoRepository<Customer>(connectionUrl);
            this.Items = new MongoRepository.MongoRepository<Item>(connectionUrl);
        }

        IRepository<Customer> Customers { get; private set; }

        IRepository<Item> Items { get; private set; }
    }
}
