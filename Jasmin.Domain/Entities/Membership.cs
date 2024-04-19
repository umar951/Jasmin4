namespace Jasmin.Domain.Entities;

public class Membership:Entity
{
   public string Type { get; set; }
   public DateTime StartDate { get; set; }
   public  DateTime EndDate { get; set; }
   public string UserId { get; set; }
   public User? User { get; set; }
   
}