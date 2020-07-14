using DevProject.Core.DataAccess.Conctete;
using DevProject.DataAccess.Abstract;
using DevProject.DataAccess.Concrete.EntityFramework.Context;
using DevProject.Entities.Concrete;

namespace DevProject.DataAccess.Concrete.EntityFramework
{
    public class EfBildirimDal : EFEntityRepositoryBase<Bildirim, DevProjectContext>, IBildirimDal
    {

    }
}
