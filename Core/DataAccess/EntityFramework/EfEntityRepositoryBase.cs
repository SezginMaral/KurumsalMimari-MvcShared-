﻿using Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Core.DataAccess.EntityFramework
{
    public class EfEntityRepositoryBase<TEntity, TContext> : IEntityRepository<TEntity> //ekleme silme güncelleme için tüm işlemleri burda yapıcaz
        where TEntity:class,IEntity,new()
        where TContext :DbContext,new()
    {



        public void Add(TEntity entity)
        {
            TContext context = new TContext();
            var addedEntity = context.Entry(entity);
            addedEntity.State = EntityState.Added;
            context.SaveChanges();
        }

        public void Delete(TEntity entity)
        {
            TContext context = new TContext();
            var addedEntity = context.Entry(entity);
            addedEntity.State = EntityState.Deleted;
            context.SaveChanges();
        }

        public TEntity Get(Expression<Func<TEntity, bool>> filter)
        {
            TContext context = new TContext();
            return context.Set<TEntity>().Where(filter).SingleOrDefault();
        }

        public IList<TEntity> getList(Expression<Func<TEntity, bool>> filter = null)
        {
            TContext context = new TContext();
            if (filter == null)
                return context.Set<TEntity>().ToList();
            else
               return  context.Set<TEntity>().Where(filter).ToList();
        }

        public void Update(TEntity entity)
        {
            TContext context = new TContext();
            var addedEntity = context.Entry(entity);
            addedEntity.State = EntityState.Modified;
            context.SaveChanges();
        }
    }
}
