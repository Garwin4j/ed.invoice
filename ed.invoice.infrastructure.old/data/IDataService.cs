using ed.invoice.domain;
using MongoRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ed.invoice.infrastructure.data
{
    public interface IDataService
    {
        IRepository<Customer> Customers { get; }
        IRepository<Item> Items { get; }
    }
}
