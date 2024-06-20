using Microsoft.EntityFrameworkCore;
using TheMamboBros.Data.Context;
using TheMamboBros.Data.Interfaces;

namespace TheMamboBros.Data.DAO
{
    public class DaoBase<TEntity> : IDaoBase<TEntity> where TEntity : class
    {
        private readonly TheMamboBrosContext _dbContext;

        public DaoBase(TheMamboBrosContext dbContext)
        {
            _dbContext = dbContext;
        }

        public virtual async Task<TEntity> CreateAsync(TEntity entity)
        {
            await _dbContext.Set<TEntity>().AddAsync(entity);
            await _dbContext.SaveChangesAsync();
            return entity;
        }

        public virtual async Task DeleteAsync(TEntity entity)
        {
            _dbContext.Set<TEntity>().Remove(entity);
            await _dbContext.SaveChangesAsync();
        }

        public virtual async Task<List<TEntity>> GetAllAsync()
        {
            List<TEntity> entities = await _dbContext.Set<TEntity>().ToListAsync();
            return entities;
        }

        public virtual async Task<TEntity> GetByIdAsync(int id)
        {
            var entity = await _dbContext.Set<TEntity>().FindAsync(id);
            return entity;
        }

        public virtual async Task UpdateAsync(TEntity entity)
        {
            _dbContext.Set<TEntity>().Update(entity);
            await _dbContext.SaveChangesAsync();
        }
    }
}