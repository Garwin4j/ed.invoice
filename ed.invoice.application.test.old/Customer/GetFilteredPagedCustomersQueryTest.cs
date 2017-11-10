using ed.invoice.application.Customer;
using ed.invoice.infrastructure.data;
using NUnit.Framework;
using SimpleInjector;
using System;
using System.Collections.Generic;
using System.Text;

namespace ed.invoice.application.test.Customer
{
    [TestFixture]
    public class GetFilteredPagedCustomersQueryTest
    {
        IQuery<GetFilteredPagedCustomersQueryResponse,GetFilteredPagedCustomersQueryRequest> getFilteredPagedCustomersQuery;
        Container container;
        IDataService dataService;

        public GetFilteredPagedCustomersQueryTest()
        {
            container = IoCConfig.Setup();
            getFilteredPagedCustomersQuery = container.GetInstance<IQuery<GetFilteredPagedCustomersQueryResponse, GetFilteredPagedCustomersQueryRequest>>();

        }

        [Test]
        public void GetFilteredPagedCustomers_NoFilterOrPaging()
        {
            ///Arrange
            var request = new GetFilteredPagedCustomersQueryRequest();

            //Act
            var response = getFilteredPagedCustomersQuery.Handle(request);

            //Assert
            Assert.IsAssignableFrom< List<ed.invoice.domain.Customer>>( response.Customers);

            //Assert.True(response.Customers.Count() > 0, "Did not return any customers");

        }
    }
}
