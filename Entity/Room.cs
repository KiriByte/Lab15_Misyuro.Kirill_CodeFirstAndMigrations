namespace Lab15_Misyuro.Kirill_CodeFirstAndMigrations.Entity;

public class Room
{
    public int Id { get; set; }
    public int Size { get; set; }
    public int Stars { get; set; }

    public ICollection<Journal> Journals { get; set; } = new List<Journal>();
}