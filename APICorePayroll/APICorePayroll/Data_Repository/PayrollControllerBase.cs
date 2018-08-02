using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APICorePayroll.Data_Repository
{
    public class PayrollControllerBase<TEntityNM> : ControllerBase, IRepository where TEntityNM : PayrollEntityBase
    {
        private IRepository IRepository { get; set; }

        public DatabaseFacade Database => IRepository.Database;

        DatabaseFacade IRepository.Database => throw new NotImplementedException();

        protected PayrollControllerBase(IRepository repository)
        {
            this.IRepository = repository;
        }

        public TEntity Get<TEntity>(int id) where TEntity : PayrollEntityBase
        {
            return IRepository.Get<TEntity>(id);
        }

        public TEntityNM Get(int id)
        {
            return IRepository.Get<TEntityNM>(id);
        }

        public IEnumerable<TEntity> Gets<TEntity>() where TEntity : PayrollEntityBase
        {
            return IRepository.Gets<TEntity>();
        }

        public IEnumerable<TEntityNM> Gets()
        {
            return IRepository.Gets<TEntityNM>();
        }

        public TEntity Add<TEntity>(TEntity entity) where TEntity : PayrollEntityBase
        {
            return IRepository.Add(entity);
        }

        public void AddRange<TEntity>(IEnumerable<TEntity> entities) where TEntity : PayrollEntityBase
        {
            IRepository.AddRange(entities);
        }

        public TEntity Remove<TEntity>(TEntity entity) where TEntity : PayrollEntityBase
        {
            TEntity exist = IRepository.Find<TEntity>(entity.Id);
            return IRepository.Remove(exist);
        }

        public void RemoveRange<TEntity>(IEnumerable<TEntity> entities) where TEntity : PayrollEntityBase
        {
            IRepository.RemoveRange(entities);
        }

        public TEntity Update<TEntity>(TEntity entity) where TEntity : PayrollEntityBase
        {
            return IRepository.Update(entity);
        }

        public void UpdateRange<TEntity>(IEnumerable<TEntity> entities) where TEntity : PayrollEntityBase
        {
            IRepository.UpdateRange(entities);
        }

        public Task<int> SaveChangesAsync()
        {
            return IRepository.SaveChangesAsync();
        }

        public void SaveChanges()
        {
            IRepository.SaveChanges();
        }

        public Task<TEntity> FindAsync<TEntity>(params object[] keyValues) where TEntity : PayrollEntityBase
        {
            return IRepository.FindAsync<TEntity>(keyValues);
        }

        public IQueryable<TEntity> AsQueryable<TEntity>() where TEntity : PayrollEntityBase
        {
            return IRepository.AsQueryable<TEntity>();
        }

        public LocalView<TEntity> Local<TEntity>() where TEntity : PayrollEntityBase
        {
            return IRepository.Local<TEntity>();
        }

        public TEntity Find<TEntity>(params object[] keyValues) where TEntity : PayrollEntityBase
        {
            return IRepository.Find<TEntity>(keyValues);
        }

        public IAsyncEnumerable<TEntity> GetsAsync<TEntity>() where TEntity : PayrollEntityBase
        {
            return this.IRepository.GetsAsync<TEntity>();
        }

        public IQueryable<TEntity> GetsAsNoTracking<TEntity>() where TEntity : PayrollEntityBase
        {
            return this.IRepository.GetsAsNoTracking<TEntity>();
        }

        protected string RemoteIpAddress()
        {
            return Request.HttpContext.Connection.RemoteIpAddress.ToString();
        }

        public IQueryable<TEntity> FromSql<TEntity>(string sql, params object[] parameters) where TEntity : PayrollEntityBase
        {
            return this.IRepository.FromSql<TEntity>(sql, parameters);
        }

        public async Task<TEntity> AddAndSave<TEntity>(TEntity entity) where TEntity : PayrollEntityBase
        {
            return await this.IRepository.AddAndSave<TEntity>(entity);
        }

        public Task<TEntity> GetAsync<TEntity>(int id) where TEntity : PayrollEntityBase
        {
            return IRepository.GetAsync<TEntity>(id);
        }

        TEntity IRepository.Get<TEntity>(int id)
        {
            throw new NotImplementedException();
        }

        Task<TEntity> IRepository.GetAsync<TEntity>(int id)
        {
            throw new NotImplementedException();
        }

        IEnumerable<TEntity> IRepository.Gets<TEntity>()
        {
            throw new NotImplementedException();
        }

        IAsyncEnumerable<TEntity> IRepository.GetsAsync<TEntity>()
        {
            throw new NotImplementedException();
        }

        IQueryable<TEntity> IRepository.GetsAsNoTracking<TEntity>()
        {
            throw new NotImplementedException();
        }

        TEntity IRepository.Add<TEntity>(TEntity entity)
        {
            throw new NotImplementedException();
        }

        Task<TEntity> IRepository.AddAndSave<TEntity>(TEntity entity)
        {
            throw new NotImplementedException();
        }

        void IRepository.AddRange<TEntity>(IEnumerable<TEntity> entities)
        {
            throw new NotImplementedException();
        }

        TEntity IRepository.Remove<TEntity>(TEntity entity)
        {
            throw new NotImplementedException();
        }

        void IRepository.RemoveRange<TEntity>(IEnumerable<TEntity> entities)
        {
            throw new NotImplementedException();
        }

        TEntity IRepository.Update<TEntity>(TEntity entity)
        {
            throw new NotImplementedException();
        }

        void IRepository.UpdateRange<TEntity>(IEnumerable<TEntity> entities)
        {
            throw new NotImplementedException();
        }

        Task<int> IRepository.SaveChangesAsync()
        {
            throw new NotImplementedException();
        }

        void IRepository.SaveChanges()
        {
            throw new NotImplementedException();
        }

        Task<TEntity> IRepository.FindAsync<TEntity>(params object[] keyValues)
        {
            throw new NotImplementedException();
        }

        TEntity IRepository.Find<TEntity>(params object[] keyValues)
        {
            throw new NotImplementedException();
        }

        IQueryable<TEntity> IRepository.AsQueryable<TEntity>()
        {
            throw new NotImplementedException();
        }

        LocalView<TEntity> IRepository.Local<TEntity>()
        {
            throw new NotImplementedException();
        }

        void IRepository.Dispose()
        {
            throw new NotImplementedException();
        }

        IQueryable<TEntity> IRepository.FromSql<TEntity>(string sql, params object[] parameters)
        {
            throw new NotImplementedException();
        }
    }

}
