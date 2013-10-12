using System;
using AutoMapper;
using Gestur.Client.Common.Dto;
using Gestur.Core.Persistance.Repository;

namespace Gestur.Server.Domain.Entities
{
  public class Visit : EntityBase
  {
    #region Constructor and static factory method

    private Visit() { }

    public static Visit Create(IRepositoryLocator locator, VisitDto dto)
    {
      var carer = locator.GetById<Carer>(dto.Carer.Id);
      var patient = locator.GetById<Patient>(dto.Patient.Id);
      var instance = Mapper.Map<VisitDto, Visit>(dto);
      instance.Carer = carer;
      instance.Patient = patient;
      return locator.Save(instance);
    }

    #endregion
    #region Properties

    public Patient Patient { get; set; }
    public DateTime VisitDateTime { get; set; }
    public Carer Carer { get; set; }
    public string Status { get; set; }

    #endregion
  }
}