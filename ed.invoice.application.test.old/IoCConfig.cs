using ed.invoice.infrastructure.data;
using SimpleInjector;
using System;
using System.Collections.Generic;
using System.Text;

namespace ed.invoice.application.test
{
    public static class IoCConfig
    {
        public static Container Setup()
        {
            Container container = new SimpleInjector.Container();

            container.Register(typeof(ICommand<>), new[] { typeof(ICommand<>).Assembly });
            container.Register(typeof(IQuery<,>), new[] { typeof(IQuery<,>).Assembly });
            container.Register(typeof(IDataService), typeof(MongoDataService));

            container.Verify();
            return container;
        }
    }
}
