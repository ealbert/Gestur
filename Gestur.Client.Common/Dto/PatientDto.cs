namespace Gestur.Client.Common.Dto
{
  public class PatientDto : IDtoWithId
  {
    public long Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public string Phone { get; set; }
    public AddressDto Address { get; set; }
    
  }
}