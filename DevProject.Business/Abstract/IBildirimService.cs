using DevProject.Entities.Concrete;
using System.Collections.Generic;

namespace DevProject.Business.Abstract
{
    public interface IBildirimService
    {
        void Add(Bildirim bildirim);
        void Delete(Bildirim bildirim);
        void Update(Bildirim bildirim);
        List<Bildirim> Bildirimler();
        Bildirim Bildirim(int id);
        List<Bildirim> OxunmamisBildirimler(int userId);
        int OxunmamusBildirimSayi(int userId);
    }
}
