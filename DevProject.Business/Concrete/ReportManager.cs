using DevProject.Business.Abstract;
using DevProject.DataAccess.Abstract;
using DevProject.Entities.Concrete;
using System.Collections.Generic;

namespace DevProject.Business.Concrete
{
    public class ReportManager : IReportService
    {
        private IReportDal _reportDal;

        public ReportManager(IReportDal reportDal)
        {
            _reportDal = reportDal;
        }

        public void Add(Report report)
        {
            _reportDal.Add(report);
        }

        public void Update(Report report)
        {
            _reportDal.Update(report);
        }

        public void Delete(Report report)
        {
            _reportDal.Delete(report);
        }

        public List<Report> Reports()
        {
            return _reportDal.GetList();
        }

        public Report GetJobWithId(int id)
        {
            return _reportDal.GetJobWithId(id);
        }

        public int ReportSayi(int userId)
        {
            return _reportDal.ReportSayi(userId);
        }

        public int ReportSayi()
        {
            return _reportDal.GetList().Count;
        }
    }
}
