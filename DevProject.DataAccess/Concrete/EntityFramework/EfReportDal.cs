using DevProject.Core.DataAccess.Conctete;
using DevProject.DataAccess.Abstract;
using DevProject.DataAccess.Concrete.EntityFramework.Context;
using DevProject.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace DevProject.DataAccess.Concrete.EntityFramework
{
    public class EfReportDal : EFEntityRepositoryBase<Report, DevProjectContext>, IReportDal
    {
        public Report GetJobWithId(int id)
        {
            using var context = new DevProjectContext();
            return context.Reports
                .Include(m => m.Job)
                .ThenInclude(m => m.Department)
                .FirstOrDefault(m => m.Id == id);
        }

        public int ReportSayi(int userId)
        {
            using var context = new DevProjectContext();
            var result = context.Jobs.Include(m => m.Reports).Where(m => m.PersonalId == userId);
            return result.SelectMany(m => m.Reports).Count();
        }
    }
}
