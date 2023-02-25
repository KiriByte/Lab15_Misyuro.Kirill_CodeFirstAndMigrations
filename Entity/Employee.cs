namespace Lab15_Misyuro.Kirill_CodeFirstAndMigrations.Entity;

public class Employee
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int PositionId { get; set; }
    
    public virtual Position Position { get; set; }

    public ICollection<Journal> Journals { get; set; } = new List<Journal>();
}