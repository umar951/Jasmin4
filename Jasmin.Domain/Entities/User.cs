namespace Jasmin.Domain.Entities;

public class User:Entity
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string  Email { get; set; }
    public string  Password { get; set; }
    public DateTime DateofBirth { get; set; }
    public string  PhoneNumber { get; set; }
    public string  Adress { get; set; }
    public string  MembershipId { get; set; }
    public List<Membership> Memberships = new List<Membership>();
    public List<Booking> Bookings = new List<Booking>();



}