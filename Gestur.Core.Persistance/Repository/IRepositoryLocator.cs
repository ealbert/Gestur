using System.Linq;

namespace Gestur.Core.Persistance.Repository
{
  public interface IRepositoryLocator
  {
    #region CRUD operations

    TEntity Save<TEntity>(TEntity instance) where TEntity : class;
    void Update<TEntity>(TEntity instance) where TEntity : class;
    void Remove<TEntity>(TEntity instance) where TEntity : class;

    #endregion
    #region Retrieval Operations

    TEntity GetById<TEntity>(long id) where TEntity : class;
    IQueryable<TEntity> FindAll<TEntity>() where TEntity : class;

    #endregion

    IRepository<T> GetRepository<T>() where T : class;
    void FlushModifications();
  }
}