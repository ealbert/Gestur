using System;
using AutoMapper;
using Gestur.Client.Common.Dto;
using Gestur.Core.Persistance.Repository;

namespace Gestur.Server.Domain.Entities
{
  public class Address : EntityBase
  {
    #region Constructor and static factory method

    private Address() { }

    public static Address Create(IRepositoryLocator locator, AddressDto dto)
    {
      var instance = Mapper.Map<AddressDto, Address>(dto);
      return locator.Save(instance);
    }

    #endregion
    #region Properties

    public String Street { get; private set; }
    public String PostalCode { get; private set; }
    public String City { get; private set; }        

    #endregion    
  }
}