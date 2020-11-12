using AutoMapper;
using BusinessLogic.Concrete;
using BusinessLogic.Interface;
using DAL.Concrete;
using DAL.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Unity;

namespace WFApp
{
    static class Program
    {
        public static UnityContainer Container;
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            ConfigureUnity();
            /*
            IRoleDal roldeDal = Container.Resolve<RoleDal>();
            roldeDal.CreateRole(new DTO.RoleDTO { Name = "Manager", Description = "User who works with products" });

            IUserDal userDal = Container.Resolve<UserDal>();

            userDal.CreateUser(new DTO.UserDTO { FirstName = "A", LastName = "B", Login = "manager", RoleId = 1,Phone = "12345" },"manager");
            */
            LoginForm login = Container.Resolve<LoginForm>();
            if(login.ShowDialog() == DialogResult.OK)
            {
                Application.Run(Container.Resolve<ProductsListForm>());
            }
            else
            {
                Application.Exit();
            }
        }

        private static void ConfigureUnity()
        {
            MapperConfiguration config = new MapperConfiguration(
               cfg =>
               {
                   cfg.AddMaps(typeof(UserDal).Assembly);
               });

            Container = new UnityContainer();
            Container.RegisterInstance<IMapper>(config.CreateMapper());

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
