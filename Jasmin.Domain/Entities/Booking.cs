namespace Jasmin.Domain.Entities;

public class Booking:Entity

{
    public  int Userid { get; set; }
    public int FitnessclassId { get; set; }
    public DateTime BokingDateTime { get; set; }
    public List<User> Users = new List<User>();
    public List<Fitnessclass> Fitnessclasses = new List<Fitnessclass>();
   
    
    

}