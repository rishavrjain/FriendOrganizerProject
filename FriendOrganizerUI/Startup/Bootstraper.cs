using Autofac;
using FriendOrganizer.DataAccess;
using FriendOrganizerUI.Data;
using FriendOrganizerUI.ViewModel;
using Prism.Events;

namespace FriendOrganizerUI.Startup
{
    public class Bootstraper
    {
        public IContainer Bootstrap()
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<EventAggregator>().As<IEventAggregator>().SingleInstance();

            builder.RegisterType<FriendOrganizerDbContext>().AsSelf();

            builder.RegisterType<MainWindow>().AsSelf();
            builder.RegisterType<MainViewModel>().AsSelf();
            builder.RegisterType<NavigationViewModel>().As<INavigationViewModel>();
            builder.RegisterType<FriendDetailViewModel>().As<IFriendDetailViewModel>();

            builder.RegisterType<FriendDataService>().As<IFriendDataService>();
            builder.RegisterType<LookupDataService>().AsImplementedInterfaces();

            return builder.Build();
        }
    }
}
