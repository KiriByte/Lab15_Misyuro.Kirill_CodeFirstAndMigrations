namespace Lab15_Misyuro.Kirill_CodeFirstAndMigrations.Entity;

public class Visitor
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Passport { get; set; }

    public ICollection<Journal> Journals { get; set; } = new List<Journal>();
}