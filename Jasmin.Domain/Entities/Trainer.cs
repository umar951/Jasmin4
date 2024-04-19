namespace Jasmin.Domain.Entities;

public class Trainer:Entity
{
   
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Specialization { get; set; }
    public long FitnessclubId { get; set; }
    public Fitnessclass? Fitnessclass { get; set; }
    
}