using Autofac;
using DevProject.Business.Abstract;
using DevProject.Business.Concrete;
using DevProject.Business.CustomLogger;
using DevProject.DataAccess.Abstract;
using DevProject.DataAccess.Concrete.EntityFramework;

namespace DevProject.Business.DependencyInjection.Autofac
{
    public class AutoFacDep : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<DepartmentManager>().As<IDepartmentService>();
            builder.RegisterType<EfDepartmentDal>().As<IDepartmentDal>();

            builder.RegisterType<JobManager>().As<IJobService>();
            builder.RegisterType<EfJobDal>().As<IJobDal>();

            builder.RegisterType<AppUserManager>().As<IAppUserService>();
            builder.RegisterType<EfAppUserDal>().As<IAppUserDal>();

            builder.RegisterType<ReportManager>().As<IReportService>();
            builder.RegisterType<EfReportDal>().As<IReportDal>();

            builder.RegisterType<BildirimManager>().As<IBildirimService>();
            builder.RegisterType<EfBildirimDal>().As<IBildirimDal>();

            builder.RegisterType<NLogLogger>().As<ICustomLogger>();
        }
    }
}
