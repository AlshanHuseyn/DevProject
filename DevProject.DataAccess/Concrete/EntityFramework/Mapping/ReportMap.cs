using DevProject.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DevProject.DataAccess.Concrete.EntityFramework.Mapping
{
    public class ReportMap : IEntityTypeConfiguration<Report>
    {
        public void Configure(EntityTypeBuilder<Report> builder)
        {
            builder.HasOne(m => m.Job).WithMany(m => m.Reports).HasForeignKey(m => m.JobId);
        }
    }
}
