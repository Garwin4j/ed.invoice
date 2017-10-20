using System;
using System.Collections.Generic;
using System.Text;

namespace ed.invoice.domain
{
    class Invoice : DomainBase
    {
        public List<LineItem> LineItems { get; set; }
        public DateTimeOffset Date { get; set; }
        public Customer Customer { get; set; }
        public Address Address { get; set; }
        public Decimal TotalCost { get; set; }
    }
}
