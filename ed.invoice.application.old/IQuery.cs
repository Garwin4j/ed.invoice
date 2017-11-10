using System;
using System.Collections.Generic;
using System.Text;

namespace ed.invoice.application
{
    public interface IQuery<Response, Request>
    {
        Response Handle(Request request);
    }
}
