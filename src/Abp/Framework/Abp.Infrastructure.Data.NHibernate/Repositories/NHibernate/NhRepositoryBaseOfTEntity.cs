using Abp.Domain.Entities;
using Abp.Domain.Repositories;

namespace Abp.Data.Repositories.NHibernate
{
    /// <summary>
    /// A shortcut of <see cref="NhRepositoryBase{TEntity,TPrimaryKey}"/> for most used primary key type (Int32).
    /// </summary>
    /// <typeparam name="TEntity">Entity type</typeparam>
    public class NhRepositoryBase<TEntity> : NhRepositoryBase<TEntity, int>, IRepository<TEntity> where TEntity : class, IEntity<int>
    {

    }
}