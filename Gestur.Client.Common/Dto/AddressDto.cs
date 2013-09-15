using System;

namespace Gestur.Client.Common.Dto
{
  public class AddressDto : IDtoWithId
  {
    public long Id { get; set; }
    public String Street { get; set; }
    public String PostalCode { get; set; }
    public String City { get; set; }        
  }
}