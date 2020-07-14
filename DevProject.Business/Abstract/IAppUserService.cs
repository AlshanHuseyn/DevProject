using DevProject.Entities.Concrete;
using System.Collections.Generic;

namespace DevProject.Business.Abstract
{
    public interface IAppUserService
    {
        /// <summary>
        /// Personal listələmək
        /// </summary>
        /// <returns></returns>
        List<AppUser> List();
        /// <summary>
        /// Job id-yə görə personal getirmək
        /// </summary>
        /// <returns></returns>
        AppUser GetByJobId(int jobId);
        /// <summary>
        /// Personal getirmək
        /// </summary>
        /// <returns></returns>
        AppUser GetById(int appUserId);
        /// <summary>
        /// Department id-yə görə personal getirmək
        /// </summary>
        /// <returns></returns>
        AppUser GetByDepId(int depId);
        /// <summary>
        /// Personal əlavə etmək
        /// </summary>
        /// <returns></returns>
        void Add(AppUser appUser);
        /// <summary>
        /// Personal məlumatlarında dəyişiklik etmək
        /// </summary>
        /// <returns></returns>
        void Update(AppUser appUser);
        /// <summary>
        /// Personal silmək
        /// </summary>
        /// <returns></returns>
        void Delete(AppUser appUser);
        /// <summary>
        /// Department id-yə görə Personallar getirmək
        /// </summary>
        /// <returns></returns>
        List<AppUser> GetDepListById(int depId);

        List<AppUser> GetListByJobId(int jobId);
        List<AppUser> GetListNotAdmin();
        List<AppUser> IsUzreIsciSayi(out int umumiSehife, int jobId, string axtarilacaqSoz, int aktivSehife);
        List<AppUser> GetListNotAdmin(out int umumiSehife, string axtarilacaqSoz, int aktivSehife);
        string IscininIsSayi();
        List<AppUser> Issizler();
        List<DualHelper> EnCoxIsTamamlamisPersonallar();
        List<DualHelper> EnCoxIsdeCalisanPersonallar();
    }
}
