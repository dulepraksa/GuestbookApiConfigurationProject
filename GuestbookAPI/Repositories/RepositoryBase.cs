using GuestbookAPI.Models;
using GuestbookAPI.Models.Guest;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace GuestbookAPI.Repositories
{
    public abstract class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {
        protected GuestbookContext GbContext { get; set; }

        public RepositoryBase(GuestbookContext gb)
        {
            this.GbContext = gb;
        }

        public void Create(T entity)
        {
            this.GbContext.Set<T>().Add(entity);
        }

        public void Delete(T entity)
        {
            throw new NotImplementedException();
        }

        public IQueryable<T> FindAll()
        {
            return this.GbContext.Set<T>().AsNoTracking();
        }

        public IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression)
        {
            return this.GbContext.Set<T>().Where(expression).AsNoTracking();
        }

        public void Update(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
