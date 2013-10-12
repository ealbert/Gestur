using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestur.Client.Common.Dto
{
  public class VisitDto
  {
    public long Id { get; set; }
    public PatientDto Patient { get; set; }
    public DateTime VisitDateTime { get; set; }
    public CarerDto Carer { get; set; }
    public string Status { get; set; }
  }
}
