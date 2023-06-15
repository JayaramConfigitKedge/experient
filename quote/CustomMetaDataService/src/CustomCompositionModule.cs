using Autofac;
using Configit.Quote.Public.Interfaces;

namespace WebApiExtensionServices.Services
{
    public class CustomCompositionModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            
            if (builder != null)
            {
                /* Defines dependency which controls the output of the CustomController in this project */
               // builder.RegisterType<CustomMessageService>().As<ICustomMessageService>();
                builder.RegisterType<CustomMetaDataService>().As<IMetaDataService>().InstancePerLifetimeScope();

             //   builder.RegisterType<CustomApprovalNotificationService>().As<IApprovalNotificationService>().InstancePerLifetimeScope();
              //  builder.RegisterType<NewRevisionCreatedEventHandler>().As<INotificationHandler<NewRevisionCreated>>().InstancePerLifetimeScope();
              //  builder.RegisterType<QuoteCopiedEventHandler>().As<INotificationHandler<CopyOfQuoteCreated>>().InstancePerLifetimeScope();
               // builder.RegisterType<CustomQuery>().AsSelf().InstancePerLifetimeScope();
               // builder.RegisterType<CustomMutation>().AsSelf().InstancePerLifetimeScope();
              //  builder.RegisterType<CoreQuoteQLExtension>().As<IQuoteQLExtension>().InstancePerLifetimeScope();
            }
                
        }
    }
}
