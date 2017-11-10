using System;
using System.Collections.Generic;
using System.Text;

namespace ed.invoice.application
{
    public interface ICommand<CommandRequest> 
    {
       void Handle(CommandRequest request);
    }
}
