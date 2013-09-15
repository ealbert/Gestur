using AutoMapper;
using Gestur.Client.Common.Dto;

namespace Gestur.Client.Domain.Entities
{
  public class AutoMapperConfigurator
  {
    public static void Install()
    {
      EntityToDto();
      DtoToEntity();
    }

    private static void EntityToDto()
    {
      Mapper.CreateMap<Carer, CarerDto>();
      Mapper.CreateMap<Address, AddressDto>();
    }

    private static void DtoToEntity()
    {
      Mapper.CreateMap<AddressDto, Address>();
    }
  }
}