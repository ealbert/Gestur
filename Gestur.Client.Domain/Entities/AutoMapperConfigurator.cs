using AutoMapper;
using Gestur.Client.Common.Dto;

namespace Gestur.Server.Domain.Entities
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

      Mapper.CreateMap<VisitDto, Visit>()
            .ForMember(e => e.Carer, m => m.Ignore())
            .ForMember(e => e.Patient, m => m.Ignore());

      Mapper.CreateMap<PatientDto, Patient>()
            .ForMember(e => e.Address, m => m.Ignore());

      Mapper.CreateMap<CarerDto, Carer>();

    }

    public static void TestMappings()
    {
      Mapper.AssertConfigurationIsValid();
    }
  }
}