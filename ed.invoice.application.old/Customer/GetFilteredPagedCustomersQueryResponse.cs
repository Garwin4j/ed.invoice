using System.Collections.Generic;

namespace ed.invoice.application.Customer
{
    public class GetFilteredPagedCustomersQueryResponse
    {
        public List<domain.Customer> Customers { get; set; }
    }
}