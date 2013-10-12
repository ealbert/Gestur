using AutoMapper;
using Gestur.Client.Common.Dto;
using Gestur.Core.Persistance.Repository;

namespace Gestur.Server.Domain.Entities
{
  public class Carer : EntityBase
  {

    #region Constructor and static factory method

    private Carer(){}
    
    public static Carer Create(IRepositoryLocator locator, CarerDto dto)
    {
      var instance = Mapper.Map<CarerDto, Carer>(dto);
      return locator.Save(instance);
    }

    #endregion
    #region Properties

    public string FirstName { get; private set; }
    public string LastName { get; private set; }
    public string Email { get; private set; }
    public string Phone { get; private set; }

    #endregion
  }
}
