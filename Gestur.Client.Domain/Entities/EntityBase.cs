using System.ComponentModel.DataAnnotations;
using Gestur.Client.Common.Message;
using Gestur.Core.Message;
using Gestur.Core.Persistance.Repository;

namespace Gestur.Client.Domain.Entities
{
  public abstract class EntityBase
    : IEntity
  {
    [Key]
    public virtual long Id { get; protected set; }

    protected static void ValidateOperation(IRepositoryLocator locator, ValidatorDtoBase operation)
    {
      if (operation.IsValid()) return;
      throw new BusinessException(BusinessExceptionEnum.Validation, operation.Error);
    }
  }
}