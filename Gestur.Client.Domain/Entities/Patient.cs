using AutoMapper;
using Gestur.Client.Common.Dto;
using Gestur.Core.Persistance.Repository;

namespace Gestur.Server.Domain.Entities
{
  public class Patient : EntityBase
  {
    #region Constructor and static factory method

    private Patient() { }

    public static Patient Create(IRepositoryLocator locator, PatientDto dto)
    {
      var instance = Mapper.Map<PatientDto, Patient>(dto);
      return locator.Save(instance);
    }

    #endregion
    #region Properties

    public string FirstName { get; private set; }
    public string Surname { get; private set; }
    public string Email { get; private set; }
    public string Telephone { get; private set; }
    public string ProfileImage { get; private set; }
    public Address Address { get; private set; }

    #endregion
  }
}