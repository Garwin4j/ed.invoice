using ed.invoice.infrastructure.data;
using Microsoft.Extensions.Configuration;
using SimpleInjector;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Text;

namespace ed.invoice.application.test
{
    public static class IoCConfig
    {
        public static Container Setup()
        {
            Container container = new SimpleInjector.Container();

            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json");

            var Configuration = builder.Build();

            container.Register(typeof(ICommand<>), new[] { typeof(ICommand<>).Assembly });
            container.Register(typeof(IQuery<,>), new[] { typeof(IQuery<,>).Assembly });
            container.Register<IConfigurationRoot>( ()=> Configuration);
            container.Register(typeof(IDataService), typeof(MongoDataService));




            container.Verify();
            return container;
        }
    }
}
