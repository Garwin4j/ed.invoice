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

        public GetFilteredPagedCustomersQuery(IDataService dataService)
        {
            this.dataService = dataService;
        }

        public GetFilteredPagedCustomersQueryResponse Handle(GetFilteredPagedCustomersQueryRequest request)
        {
            var customers = dataService.Customers.AsQueryable().Skip(request.PageNumber * request.PageSize).Take(request.PageSize);
            if(!String.IsNullOrEmpty(request.FirstNameFilter))
            {
                customers = customers.Where(x => x.FirstName.Contains(request.FirstNameFilter) || request.FirstNameFilter == null);
            }
            return new GetFilteredPagedCustomersQueryResponse
            {
                Customers = customers.ToList()
            };
        }
    }
}
