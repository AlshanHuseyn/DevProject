using DevProject.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DevProject.DataAccess.Concrete.EntityFramework.Mapping
{
    public class BildirimMap : IEntityTypeConfiguration<Bildirim>
    {
        public void Configure(EntityTypeBuilder<Bildirim> builder)
        {
            builder.HasKey(m => m.Id);
            builder.Property(m => m.Id).UseIdentityColumn();

            builder.Property(m => m.Aciqlama).HasColumnType("ntext").IsRequired();

            builder.HasOne(m => m.User)
                .WithMany(m => m.Bildirimler).HasForeignKey(m => m.UserId);
        }
    }
}
