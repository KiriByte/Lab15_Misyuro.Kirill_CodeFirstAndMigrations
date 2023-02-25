namespace Lab15_Misyuro.Kirill_CodeFirstAndMigrations.Entity;

public class Journal
{
    public int Id { get; set; }
    public int VisitorId { get; set; }
    public int RoomId { get; set; }
    public DateTime DateStart { get; set; }
    public DateTime DateEnd { get; set; }
    public int EmployeeId { get; set; }
    
    public Employee Employee { get; set; }
    public Room Room { get; set; }
    public Visitor Visitor { get; set; }
}