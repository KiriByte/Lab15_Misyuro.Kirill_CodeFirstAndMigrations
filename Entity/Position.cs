using System.Data.SqlTypes;

namespace Lab15_Misyuro.Kirill_CodeFirstAndMigrations.Entity;

public class Position
{
    public int Id { get; set; }
    public string PositionName { get; set; }
    public float Salary { get; set; }
    public float Rate { get; set; }
    public ICollection<Employee> Employes { get; set; } = new List<Employee>();
}