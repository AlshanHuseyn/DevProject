using DevProject.Business.Abstract;
using DevProject.DataAccess.Abstract;
using DevProject.Entities.Concrete;
using System.Collections.Generic;
using System.Linq;

namespace DevProject.Business.Concrete
{
    public class AppUserManager : IAppUserService
    {
        private IAppUserDal _appUserDal;

        public AppUserManager(IAppUserDal appUserDal)
        {
            _appUserDal = appUserDal;
        }

        public List<AppUser> List()
        {
            return _appUserDal.GetList();
        }

        public AppUser GetByJobId(int jobId)
        {
            if (jobId <= 0)
            {
                throw new System.NotImplementedException();
            }
            return _appUserDal.Get(m => m.JobId == jobId);
        }

        public AppUser GetById(int appUserId)
        {
            if (appUserId <= 0)
            {
                throw new System.NotImplementedException();
            }
            return _appUserDal.Get(m => m.Id == appUserId);
        }

        public AppUser GetByDepId(int depId)
        {
            if (depId <= 0)
            {
                throw new System.NotImplementedException();
            }
            return _appUserDal.Get(m => m.DepartmentId == depId);
        }

        public void Add(AppUser appUser)
        {
            if (appUser == null)
            {
                throw new System.NotImplementedException();
            }
            _appUserDal.Add(appUser);
        }

        public void Update(AppUser appUser)
        {
            if (appUser == null)
            {
                throw new System.NotImplementedException();
            }

            _appUserDal.Update(appUser);
        }

        public void Delete(AppUser appUser)
        {
            if (appUser == null)
            {
                throw new System.NotImplementedException();
            }
            _appUserDal.Delete(appUser);
        }

        public List<AppUser> GetDepListById(int depId)
        {
            if (depId <= 0)
            {
                throw new System.NotImplementedException();
            }

            return _appUserDal.GetList(m => m.DepartmentId == depId);
        }

        public List<AppUser> GetListByJobId(int jobId)
        {
            if (jobId <= 0)
            {
                throw new System.NotImplementedException();
            }

            return _appUserDal.GetList(m => m.JobId == jobId);
        }

        public List<AppUser> GetListNotAdmin()
        {
            return _appUserDal.GetListNotAdmin();
        }

        public List<AppUser> IsUzreIsciSayi(out int umumiSehife, int jobId, string axtarilacaqSoz, int aktivSehife)
        {
            return _appUserDal.IsUzreIsciSayi(out umumiSehife, jobId, axtarilacaqSoz, aktivSehife);
        }

        public List<AppUser> GetListNotAdmin(out int umumiSehife, string axtarilacaqSoz, int aktivSehife)
        {
            return _appUserDal.GetListNotAdmin(out umumiSehife, axtarilacaqSoz, aktivSehife);
        }

        public string IscininIsSayi()
        {
            return _appUserDal.IscininIsSayi();
        }

        public List<AppUser> Issizler()
        {
            return _appUserDal.GetList(m => m.JobId == null).ToList();
        }

        public List<DualHelper> EnCoxIsTamamlamisPersonallar()
        {
            return _appUserDal.EnCoxIsTamamlamisPersonallar();
        }

        public List<DualHelper> EnCoxIsdeCalisanPersonallar()
        {
            return _appUserDal.EnCoxIsdeCalisanPersonallar();
        }
    }
}
