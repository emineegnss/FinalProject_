using Autofac;
using Autofac.Extras.DynamicProxy;
using Business.Abstract;
using Business.CCS;
using Business.Concrete;
using Castle.DynamicProxy;
using Core.Utilities.Interceptors;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Business.DependencyResolvers.Autofac
{
    //Program.cs de kurduş olduğumuz IoC yi autofac de bu şekilde kuruyoruz.
    //AOP yapabilmek için Autofac yapısını kullanıyoruz
    public class AutofacBusinessModule : Module
    {
        //Uygulama ayağa kalktığı zaman burası çalışır
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<ProductManager>().As<IProductService>().SingleInstance(); //Birisi senden IProductServices isterse ona Product Manager gönder
            builder.RegisterType<EfProductDal>().As<IProductDal>().SingleInstance();
            builder.RegisterType<CategoryManager>().As<ICategoryService>().SingleInstance(); 
            builder.RegisterType<EfCategoryDal>().As<ICategoryDal>().SingleInstance();

            var assembly = System.Reflection.Assembly.GetExecutingAssembly();

            builder.RegisterAssemblyTypes(assembly).AsImplementedInterfaces()
                .EnableInterfaceInterceptors(new ProxyGenerationOptions()
                {
                    Selector = new AspectInterceptorSelector()
                }).SingleInstance();
        }
    }
}
