using DevProject.Core.DataAccess.Abstract;
using DevProject.Entities.Concrete;
using System.Collections.Generic;

namespace DevProject.DataAccess.Abstract
{
    public interface IAppUserDal : IEntityRepository<AppUser>
    {
        List<AppUser> GetListNotAdmin();
        List<AppUser> IsUzreIsciSayi(out int umumiSehife, int jobId, string axtarilacaqSoz, int aktivSehife = 1);
        List<AppUser> GetListNotAdmin(out int umumiSehife, string axtarilacaqSoz, int aktivSehife = 1);
        string IscininIsSayi();
        List<DualHelper> EnCoxIsTamamlamisPersonallar();
        List<DualHelper> EnCoxIsdeCalisanPersonallar();
    }
}
