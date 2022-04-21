using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using DataAccess.Abstract;
using DataAccess.Concreate.EntityFramework.Contexts;
using Entity.Abstract;

namespace DataAccess.Concreate.EntityFramework
{
    public class EfEntityRepositoryBase<TEntity,TContext>:IEntityRepository<TEntity> where TEntity:class,IEntity,new () where TContext:DbContext,new()
    {
        public List<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null)
        {
            using (var context= new TContext())
            {
                return filter == null ? context.Set<TEntity>().ToList() : context.Set<TEntity>().Where(filter).ToList();
            }
        }

        public TEntity Get(Expression<Func<TEntity, bool>> filter)
        {
            using (var context= new TContext())
            {
                return context.Set<TEntity>().SingleOrDefault(filter);
            }
        }

        public void Add(TEntity entity)
        {
            using (var context= new TContext())
            {
                var addedEntity = context.Entry(entity);
                addedEntity.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Delete(TEntity entity)
        {
            using (var context= new TContext())
            {
                var deletedEntity = context.Entry(entity);
                deletedEntity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public void Update(TEntity entity)
        {
            using (var context= new TContext())
            {
                var updatedEntity = context.Entry(entity);
                updatedEntity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }

        public void UpdateColumn(TEntity entity,Expression<Func<TEntity,object>>[] properties)
        {
            //using (var context= new PansiyonContext())
            //{
            //    context.Entry(entity);
            //    foreach (var property in properties)
            //    {
            //        context.Entry(entity).Property(property).IsModified = true;
            //    }

            //    context.SaveChanges();
            //}

            using (var context= new PansiyonContext())
            {
                var entry = context.Entry(entity);

                context.Set<TEntity>().Attach(entity);

                foreach (var property in properties)
                {
                    entry.Property(property).IsModified = true;
                    
                }
                context.SaveChanges();
            }


        }
    }
}