using System;
using System.Collections.Generic;
using System.Text;

namespace ed.invoice.domain
{
    public class DomainBase
    {
        public String CreatedBy { get; set; }
        public DateTimeOffset CreatedDate { get; set; }
        public String ModifiedBy { get; set; }
        public DateTimeOffset ModifiedDate { get; set; }
    }
}
