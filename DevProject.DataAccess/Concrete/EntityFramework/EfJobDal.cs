using DevProject.Core.DataAccess.Conctete;
using DevProject.DataAccess.Abstract;
using DevProject.DataAccess.Concrete.EntityFramework.Context;
using DevProject.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace DevProject.DataAccess.Concrete.EntityFramework
{
    public class EfJobDal : EFEntityRepositoryBase<Job, DevProjectContext>, IJobDal
    {
        public Job getirDepIdile(int id)
        {
            using var context = new DevProjectContext();
            return context.Jobs.Include(m => m.Department)
                .FirstOrDefault(m => !m.Status && m.Id == id);
        }

        public List<Job> butunCedveler()
        {
            using var context = new DevProjectContext();
            return context.Jobs
                .Include(m => m.Department)
                .Include(m => m.Reports)
                .Include(m => m.User)
                .Where(m => !m.Status).OrderByDescending(m => m.CreationDate).ToList();
        }

        public List<Job> butunCedveler(Expression<Func<Job, bool>> filter)
        {
            using var context = new DevProjectContext();
            return context.Jobs
                .Include(m => m.Department)
                .Include(m => m.Reports)
                .Include(m => m.User)
                .Where(filter).OrderByDescending(m => m.CreationDate).ToList();
        }

        public List<Job> butunCedvelerTamamlanmayan
            (out int umumiSehife, int userId, int aktivSehife = 1)
        {
            using var context = new DevProjectContext();
            var result = context.Jobs
                .Include(m => m.Department)
                .Include(m => m.Reports)
                .Include(m => m.User)
                .Where(m => m.Id == userId && m.Status)
                .OrderByDescending(m => m.CreationDate);

            umumiSehife = (int)Math.Ceiling((double)result.Count() / 3);

            return result.Skip((aktivSehife - 1) * 3).Take(3).ToList();
        }

        public int JobSayiTamamlanan(int userId)
        {
            using var context = new DevProjectContext();
            return context.Jobs.Count(m => m.PersonalId == userId && m.Status);
        }
    }
}
