using ed.invoice.infrastructure.data;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ed.invoice.application.Customer
{
    public class GetFilteredPagedCustomersQuery : IQuery<GetFilteredPagedCustomersQueryResponse, GetFilteredPagedCustomersQueryRequest>
    {
        IDataService dataService;

        public GetFilteredPagedCustomersQuery(        IDataService dataService)
        {
            this.dataService = dataService;
        }

        public GetFilteredPagedCustomersQueryResponse Handle(GetFilteredPagedCustomersQueryRequest request)
        {
            return new GetFilteredPagedCustomersQueryResponse
            {
                 Customers = this.dataService.Customers.ToList(),
            };
        }
    }
}
