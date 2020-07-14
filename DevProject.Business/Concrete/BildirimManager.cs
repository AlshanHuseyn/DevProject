using DevProject.Business.Abstract;
using DevProject.DataAccess.Abstract;
using DevProject.Entities.Concrete;
using System.Collections.Generic;

namespace DevProject.Business.Concrete
{
    public class BildirimManager : IBildirimService
    {
        private IBildirimDal _bildirimDal;

        public BildirimManager(IBildirimDal bildirimDal)
        {
            _bildirimDal = bildirimDal;
        }

        public void Add(Bildirim bildirim)
        {
            _bildirimDal.Add(bildirim);
        }

        public void Delete(Bildirim bildirim)
        {
            _bildirimDal.Delete(bildirim);
        }

        public void Update(Bildirim bildirim)
        {
            _bildirimDal.Update(bildirim);
        }

        public List<Bildirim> Bildirimler()
        {
            return _bildirimDal.GetList();
        }

        public Bildirim Bildirim(int id)
        {
            return _bildirimDal.Get(m => m.Id == id);
        }

        public List<Bildirim> OxunmamisBildirimler(int userId)
        {
            return _bildirimDal.GetList(m => !m.Status && m.User.Id == userId);
        }

        public int OxunmamusBildirimSayi(int userId)
        {
            return _bildirimDal.GetList(m => m.UserId == userId && !m.Status).Count;
        }
    }
}
