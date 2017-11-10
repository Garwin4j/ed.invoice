using ed.invoice.application.Customer;
using ed.invoice.infrastructure.data;

using SimpleInjector;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using System.Linq;
using ed.invoice.domain;

namespace ed.invoice.application.test.Customer
{

    public class GetFilteredPagedCustomersQueryTest
    {
        IQuery<GetFilteredPagedCustomersQueryResponse,GetFilteredPagedCustomersQueryRequest> getFilteredPagedCustomersQuery;
        Container container;
        IDataService dataService;
        domain.Customer existingCustomer;
        public GetFilteredPagedCustomersQueryTest()
        {
            container = IoCConfig.Setup();
            getFilteredPagedCustomersQuery = container.GetInstance<IQuery<GetFilteredPagedCustomersQueryResponse, GetFilteredPagedCustomersQueryRequest>>();

            dataService = container.GetInstance<IDataService>();

            for (int i = 0; i < 12; i++)
            {
                dataService.Customers.Add(new domain.Customer
                {
                     FirstName = Faker.NameFaker.FirstName(),
                     LastName = Faker.NameFaker.LastName(),
                     Email = Faker.InternetFaker.Email(),
                     PhoneNumber = Faker.PhoneFaker.InternationalPhone(),
                     Addresses = new List<Address>
                     {
                         new Address{ AddressLine = Faker.LocationFaker.StreetName()}
                     }
                });
            }
            existingCustomer = dataService.Customers.Find(x=> x.FirstName != null);
        }

        [Fact]
        public void GetFilteredPagedCustomers_NoFilterOrPaging()
        {
            ///Arrange
            var request = new GetFilteredPagedCustomersQueryRequest();

            //Act
            var response = getFilteredPagedCustomersQuery.Handle(request);

            //Assert
            Assert.IsAssignableFrom< List<ed.invoice.domain.Customer>>( response.Customers);

            Assert.True(response.Customers.Count > 0, "Did not return any customers");
        }

        [Fact]
        public void GetFilteredPagedCustomers_OnlyFirstTen()
        {
            ///Arrange
            var request = new GetFilteredPagedCustomersQueryRequest();
            request.PageSize = 10;
            //Act
            var response = getFilteredPagedCustomersQuery.Handle(request);

            Assert.True(response.Customers.Count == 10, "Did not return any customers");
        }

        [Fact]
        public void GetFilteredPagedCustomers_OnlyWhereFirstNameStartWithALetter()
        {
            ///Arrange
            var request = new GetFilteredPagedCustomersQueryRequest();
            request.FirstNameFilter = existingCustomer.FirstName.First().ToString();
            request.PageSize = 10;
            //Act
            var response = getFilteredPagedCustomersQuery.Handle(request);

            Assert.True(response.Customers.Count > 0, "Did not return any customers");
        }
    }
}
