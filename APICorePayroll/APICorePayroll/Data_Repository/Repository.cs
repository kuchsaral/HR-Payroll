using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Query.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace APICorePayroll.Data_Repository
{
    public class Repository : IRepository
    {
        private PayrollContext _dbContext = null;

        public Repository(PayrollContext context)
        {
            this._dbContext = context;
        }

        DatabaseFacade IRepository.Database => this._dbContext.Database;

        TEntity IRepository.Add<TEntity>(TEntity entity)
        {
            return _dbContext.Set<TEntity>().Add(entity.Clone()).Entity.Clone();
        }

        async Task<TEntity> IRepository.AddAndSave<TEntity>(TEntity entity)
        {
            entity = entity.Clone();
            var result = _dbContext.Set<TEntity>().AddAsync(entity);
            await this._dbContext.SaveChangesAsync();
            return (await result).Entity.Clone();
        }

        void IRepository.AddRange<TEntity>(IEnumerable<TEntity> entities)
        {
            _dbContext.Set<TEntity>().AddRange(entities.SelectClone());
        }

        IQueryable<TEntity> IRepository.AsQueryable<TEntity>()
        {
            return _dbContext.Set<TEntity>().AsQueryable();
        }

        void IRepository.Dispose()
        {
            this._dbContext.Dispose();
        }

        TEntity IRepository.Find<TEntity>(params object[] keyValues)
        {
            return this._dbContext.Find<TEntity>(keyValues);
        }

        Task<TEntity> IRepository.FindAsync<TEntity>(params object[] keyValues)
        {
            return this._dbContext.Set<TEntity>().FindAsync(keyValues);
        }

        TEntity IRepository.Get<TEntity>(int id)
        {
            return this._dbContext.Find<TEntity>(id).Clone();
        }

        Task<TEntity> IRepository.GetAsync<TEntity>(int id)
        {
            return this._dbContext.FindAsync<TEntity>(id);
        }

        IEnumerable<TEntity> IRepository.Gets<TEntity>()
        {
            return this._dbContext.Set<TEntity>().SelectClone();
        }

        [MethodImpl(MethodImplOptions.NoOptimization)]

        LocalView<TEntity> IRepository.Local<TEntity>()
        {
            return this._dbContext.Set<TEntity>().Local;
        }

        TEntity IRepository.Remove<TEntity>(TEntity entity)
        {
            TEntity exist = this._dbContext.Set<TEntity>().Find(entity.Id);
            return _dbContext.Set<TEntity>().Remove(exist).Entity;
        }

        void IRepository.RemoveRange<TEntity>(IEnumerable<TEntity> entities)
        {
            var exist = _dbContext.Set<TEntity>().Where(line => entities.Any(x => x.Id == line.Id));
            _dbContext.Set<TEntity>().RemoveRange(exist);
        }

        void IRepository.SaveChanges()
        {
            this._dbContext.SaveChanges();
        }

        Task<int> IRepository.SaveChangesAsync()
        {
            return _dbContext.SaveChangesAsync();
        }

        TEntity IRepository.Update<TEntity>(TEntity entity)
        {
            TEntity exist = _dbContext.Find<TEntity>(entity.Id);
            this._dbContext.Entry<TEntity>(exist).CurrentValues.SetValues(entity);
            return entity;
        }

        void IRepository.UpdateRange<TEntity>(IEnumerable<TEntity> entities)
        {
            foreach (TEntity entity in entities)
            {
                TEntity exist = this._dbContext.Find<TEntity>(entity.Id);
                this._dbContext.Entry<TEntity>(exist).CurrentValues.SetValues(entity);
            }
        }

        [MethodImpl(MethodImplOptions.NoOptimization)]
        IAsyncEnumerable<TEntity> IRepository.GetsAsync<TEntity>()
        {
            IAsyncEnumerableAccessor<TEntity> source = this._dbContext.Set<TEntity>();
            return source.AsyncEnumerable;
        }

        [MethodImpl(MethodImplOptions.NoOptimization)]
        IQueryable<TEntity> IRepository.GetsAsNoTracking<TEntity>()
        {
            return this._dbContext.Set<TEntity>().AsNoTracking();
        }

        public IQueryable<TEntity> FromSql<TEntity>(string sql, params object[] parameters) where TEntity : PayrollEntityBase
        {
            return this._dbContext.Set<TEntity>().FromSql(sql, parameters);
        }

        IQueryable<TEntity> IRepository.FromSql<TEntity>(string sql, params object[] parameters)
        {
            throw new NotImplementedException();
        }
    }
}
