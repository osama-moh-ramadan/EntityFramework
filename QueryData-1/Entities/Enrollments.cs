namespace MigrationIntial.Entities;

public class Enrollments
{
    public int  SectionId { get; set; }
    public int  StudentId { get; set; }
    public Particpant? Particpant { get; set; }
    public Section? Section { get; set; }
}