using System.Collections.Generic;
using Gestur.Core.Message;

namespace Gestur.Client.Common.Dto
{
  public class GetVisitsResponse : DtoBase
  {
    List<VisitDto> VisitDtos { get; set; }
  }
}