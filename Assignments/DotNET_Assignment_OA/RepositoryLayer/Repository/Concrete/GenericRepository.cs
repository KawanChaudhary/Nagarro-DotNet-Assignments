using Microsoft.EntityFrameworkCore;
using RepositoryLayer.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryLayer.Repository.Concrete
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class
    {
        protected BookEventContext context;
        internal DbSet<TEntity> dbSet;

        public GenericRepository(BookEventContext context)
        {
            this.context = context;
            this.dbSet = context.Set<TEntity>();
        }

        public virtual async Task<TEntity> GetById(Guid id)
        {
            return await dbSet.FindAsync(id);
        }

        public virtual async Task<TEntity> GetById(int id)
        {
            return await dbSet.FindAsync(id);
        }

        public virtual async Task<bool> Add(TEntity entity)
        {
            await dbSet.AddAsync(entity);
            return true;
        }


        public virtual async Task<IEnumerable<TEntity>> All()
        {
            try
            {
                return await dbSet.ToListAsync();
            }
            catch (Exception ex)
            {
                return new List<TEntity>();
            }
        }

        public async Task<IEnumerable<TEntity>> Find(Expression<Func<TEntity, bool>> predicate)
        {
            return await dbSet.Where(predicate).ToListAsync();
        }

        public virtual Task<bool> Update(TEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
