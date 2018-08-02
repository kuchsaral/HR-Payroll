using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APICorePayroll.Data_Repository
{
    public interface IRepository
    {
        TEntity Get<TEntity>(int id) where TEntity : PayrollEntityBase;

        Task<TEntity> GetAsync<TEntity>(int id) where TEntity : PayrollEntityBase;

        IEnumerable<TEntity> Gets<TEntity>() where TEntity : PayrollEntityBase;

        IAsyncEnumerable<TEntity> GetsAsync<TEntity>() where TEntity : PayrollEntityBase;

        IQueryable<TEntity> GetsAsNoTracking<TEntity>() where TEntity : PayrollEntityBase;

        TEntity Add<TEntity>(TEntity entity) where TEntity : PayrollEntityBase;

        Task<TEntity> AddAndSave<TEntity>(TEntity entity) where TEntity : PayrollEntityBase;

        void AddRange<TEntity>(IEnumerable<TEntity> entities) where TEntity : PayrollEntityBase;

        TEntity Remove<TEntity>(TEntity entity) where TEntity : PayrollEntityBase;

        void RemoveRange<TEntity>(IEnumerable<TEntity> entities) where TEntity : PayrollEntityBase;

        TEntity Update<TEntity>(TEntity entity) where TEntity : PayrollEntityBase;

        void UpdateRange<TEntity>(IEnumerable<TEntity> entities) where TEntity : PayrollEntityBase;

        Task<int> SaveChangesAsync();

        void SaveChanges();

        Task<TEntity> FindAsync<TEntity>(params object[] keyValues) where TEntity : PayrollEntityBase;

        TEntity Find<TEntity>(params object[] keyValues) where TEntity : PayrollEntityBase;

        IQueryable<TEntity> AsQueryable<TEntity>() where TEntity : PayrollEntityBase;

        LocalView<TEntity> Local<TEntity>() where TEntity : PayrollEntityBase;

        DatabaseFacade Database { get; }

        void Dispose();

        IQueryable<TEntity> FromSql<TEntity>(string sql, params object[] parameters) where TEntity : PayrollEntityBase;
    }
}
