using AutoMapper;
using BusinessLogic.Concrete;
using BusinessLogic.Interface;
using DAL.Concrete;
using DAL.Interface;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using Unity;
using WPFApp.Windows;

namespace WPFApp
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        public IUnityContainer Container;
        protected override void OnStartup(StartupEventArgs e)
        {
            Current.ShutdownMode = ShutdownMode.OnExplicitShutdown;

            base.OnStartup(e);
            RegisterUnity();
            RegisterAutoMapper();

            Login lf = Container.Resolve<Login>();
            bool result = lf.ShowDialog() ?? false;
            if (result)
            {
                
                Manage ml = Container.Resolve<Manage>();
                Current.ShutdownMode = ShutdownMode.OnMainWindowClose;
                Current.MainWindow = ml;
                ml.Show();
                
            }
            else
            {
                Current.Shutdown();
            }
        }

        private void RegisterAutoMapper()
        {
            MapperConfiguration config = new MapperConfiguration(
              cfg =>
              {
                  cfg.AddMaps(typeof(UserDal).Assembly);
              });

            Container.RegisterInstance(config.CreateMapper());
        }

        private void RegisterUnity()
        {
            

            Container = new UnityContainer();

            Container.RegisterType<IUserDal, UserDal>()
                .RegisterType<IRoleDal, RoleDal>()
                .RegisterType<IProductDal, ProductDal>()
                .RegisterType<ICategoryDal, CategoryDal>();

            Container.RegisterType<IAuthManager, AuthManager>()
                .RegisterType<ICategoryManager, CategoryManager>()
                .RegisterType<IProductManager, ProductManager>()
                .RegisterType<IRoleManager, RoleManager>();
        }
    }
}
