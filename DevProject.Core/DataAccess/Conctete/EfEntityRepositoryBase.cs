using DevProject.Core.DataAccess.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace DevProject.Core.DataAccess.Conctete
{
    public class EFEntityRepositoryBase<TEntity, TContext> : IEntityRepository<TEntity>
        where TEntity : class, new()
        where TContext : DbContext, new()
    {
        public void Add(TEntity entity)
        {
            using TContext context = new TContext();
            //var addedEntity = context.Entry(entity);
            //addedEntity.State = EntityState.Added;
            context.Entry(entity).State = EntityState.Added;
            context.SaveChanges();
        }

        public void Delete(TEntity entity)
        {
            using TContext context = new TContext();
            context.Entry(entity).State = EntityState.Deleted;
            context.SaveChanges();
        }

        public TEntity Get(Expression<Func<TEntity, bool>> filter)
        {
            using TContext context = new TContext();
            return context.Set<TEntity>().SingleOrDefault(filter);
        }
        public List<TEntity> GetList(Expression<Func<TEntity, bool>> filter = null)
        {
            using TContext context = new TContext();
            return filter == null ?
            context.Set<TEntity>().ToList() :
            context.Set<TEntity>().Where(filter).ToList();
        }
        public void Update(TEntity entity)
        {
            using TContext context = new TContext();
            context.Entry(entity).State = EntityState.Modified;
            context.SaveChanges();
        }
    }
}
