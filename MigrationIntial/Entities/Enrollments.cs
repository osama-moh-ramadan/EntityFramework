namespace MigrationIntial.Entities;

public class Enrollments
{
    public int  SectionId { get; set; }
    public int  StudentId { get; set; }
    public Student? Student { get; set; }
    public Section? Section { get; set; }
}