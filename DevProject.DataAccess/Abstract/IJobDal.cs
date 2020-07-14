using DevProject.Core.DataAccess.Abstract;
using DevProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace DevProject.DataAccess.Abstract
{
    public interface IJobDal : IEntityRepository<Job>
    {
        Job getirDepIdile(int id);
        List<Job> butunCedveler();
        List<Job> butunCedveler(Expression<Func<Job, bool>> filter);
        List<Job> butunCedvelerTamamlanmayan(out int umumiSehife, int userId, int aktivSehife);
        int JobSayiTamamlanan(int userId);
    }
}
