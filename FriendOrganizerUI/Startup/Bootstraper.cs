using Autofac;
using FriendOrganizer.DataAccess;
using FriendOrganizerUI.Data;
using FriendOrganizerUI.ViewModel;

namespace FriendOrganizerUI.Startup
{
    public class Bootstraper
    {
        public IContainer Bootstrap()
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<FriendOrganizerDbContext>().AsSelf();
            builder.RegisterType<MainWindow>().AsSelf();
            builder.RegisterType<MainViewModel>().AsSelf();
            builder.RegisterType<FriendDataService>().As<IFriendDataService>();

            return builder.Build();
        }
    }
}
