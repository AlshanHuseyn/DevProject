using DevProject.Core.DataAccess.Abstract;
using DevProject.Entities.Concrete;

namespace DevProject.DataAccess.Abstract
{
    public interface IReportDal : IEntityRepository<Report>
    {
        Report GetJobWithId(int id);
        int ReportSayi(int userId);
    }
}
