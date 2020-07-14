using DevProject.Entities.Concrete;
using System.Collections.Generic;

namespace DevProject.Business.Abstract
{
    public interface IReportService
    {
        void Add(Report report);
        void Update(Report report);
        void Delete(Report report);
        List<Report> Reports();
        Report GetJobWithId(int id);
        int ReportSayi(int userId);
        int ReportSayi();
    }
}
