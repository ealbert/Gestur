using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestur.Client.Common.Dto
{
  public class CarerDto : IDtoWithId
  {
    public long Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
  }
}
