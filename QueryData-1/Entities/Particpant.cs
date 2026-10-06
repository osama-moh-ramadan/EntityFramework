namespace MigrationIntial.Entities;

public class Particpant
{
    public int Id { get; set; }
    public string? FName { get; set; }
    public string? LName { get; set; }
    public ICollection<Section> Sections { get; set; } = new List<Section>();
}public class Individual:Particpant
{
    public string University { get; set; }
    public int  YearOfGraduation { get; set; }
    public bool IsIntern { get; set; }
}public class Coporate:Particpant
{
    public string Company { get; set; }
    public string JobTitle { get; set; }
}