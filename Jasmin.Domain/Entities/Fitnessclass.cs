namespace Jasmin.Domain.Entities;

public class Fitnessclass:Entity
{
    public string ClassName { get; set; }
    public string Description { get; set; }
    public int Capacity { get; set; }
    public DateTime Schedule { get; set; }
    public  int TrainerId { get; set; }
    
}