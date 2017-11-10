using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ed.invoice.application;
using ed.invoice.application.Customer;

namespace ed.invoice.api.Controllers
{
    [Route("api/[controller]")]
    public class CustomerController : Controller
    {
        IQuery<GetFilteredPagedCustomersQueryResponse, GetFilteredPagedCustomersQueryRequest> getCustomerQuery;

        public CustomerController(IQuery<GetFilteredPagedCustomersQueryResponse, GetFilteredPagedCustomersQueryRequest> getCustomerQuery)
        {
            this.getCustomerQuery = getCustomerQuery;
        }

        [HttpGet]
        public IActionResult Get(Int32 PageNumber = 1)
        {
            var response = getCustomerQuery.Handle(new GetFilteredPagedCustomersQueryRequest { PageNumber = PageNumber });
            return  this.Ok(response.Customers);
        }
    }
}