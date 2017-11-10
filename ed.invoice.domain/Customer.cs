using MongoRepository;
using System;
using System.Collections.Generic;
using System.Text;

namespace ed.invoice.domain
{
    public class Customer : Entity
    {
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public List<Address> Addresses { get; set; }
        public String Email { get; set; }
        public String PhoneNumber { get; set; }
    }
}
