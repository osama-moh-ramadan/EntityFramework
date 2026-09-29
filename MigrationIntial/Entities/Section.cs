namespace MigrationIntial.Entities;

public class Section
{
    public int Id { get; set; }
    public string SectionName { get; set; }
    public int  CourseId { get; set; } // this ralationship is required 
    public Course Course { get; set; }
    public int? InstructorId { get; set; } // this relationship is optional
    public Instructor? Instructor { get; set; }
    public ICollection<Schedule> Schedules { get; set; } = new List<Schedule>();
    public ICollection<Student> Students { get; set; } = new List<Student>();
    public ICollection<SectionSchedule> SectionSchedules{ get; set; } = new List<SectionSchedule>();
}