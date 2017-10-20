using ed.invoice.domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ed.invoice.infrastructure.data
{
    public interface IDataService
    {
         IQueryable<Customer> Customers { get; }
         IQueryable<Item> Items { get; }
    }
}
