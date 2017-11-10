using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ed.invoice.domain;
using MongoDB.Driver;
using System.Configuration;
using MongoRepository;
using Microsoft.Extensions.Configuration;


namespace ed.invoice.infrastructure.data
{
    public class MongoDataService : IDataService
    {

        public MongoDataService(IConfigurationRoot configuration)
        {
            var connectionUrlString = configuration["MongoSettings:ConnectionString"];
            var connectionUrl = new MongoUrl(connectionUrlString);
            this.Customers = new MongoRepository<Customer>(connectionUrl);
            this.Items = new MongoRepository<Item>(connectionUrl);
        }

        public IRepository<Customer> Customers { get; private set; }

        public IRepository<Item> Items { get; private set; }
    }
}
