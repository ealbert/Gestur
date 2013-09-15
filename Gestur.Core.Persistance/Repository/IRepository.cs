using System.Linq;

namespace Gestur.Core.Persistance.Repository
{
  public interface IRepository<TEntity>
  {
    #region CRUD operations

    TEntity Save(TEntity instance);
    void Update(TEntity instance);
    void Remove(TEntity instance);

    #endregion
    #region Retrieval Operations

    TEntity GetById(long id);
    IQueryable<TEntity> FindAll();

    #endregion
  }
}
