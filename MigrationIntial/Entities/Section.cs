namespace MigrationIntial.Entities;

public class Section
{
    public int Id { get; set; }
    public string SectionName { get; set; }
    public int  CourseId { get; set; } // this ralationship is required 
    public Course Course { get; set; }
    public int? InstructorId { get; set; } // this relationship is optional
    public Instructor? Instructor { get; set; }
}