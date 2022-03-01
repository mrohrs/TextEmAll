namespace TextEmAll.Repository.Core;

/// <summary>
/// StudentGrade Entity Model
/// </summary>
[Table("StudentGrade")]
public class StudentGrade
{
	[Key]
	[Column(name: nameof(EnrollmentId), Order = 0, TypeName = "int")]
	[Required(ErrorMessage = "Enrollment Id is a required field")]
	public int EnrollmentId { get; set; }

	[ForeignKey("Course")]
	[Column(name: nameof(CourseId), Order = 1, TypeName = "int")]
	[Required(ErrorMessage = "CourseId Id is a required field")]
	public int CourseId { get; set; }

	[ForeignKey("Person")]
	[Column(name: nameof(StudentId), Order = 2, TypeName = "int")]
	[Required(ErrorMessage = "Student Id is a required field")]
	public int StudentId { get; set; }

	[Column(name: nameof(Grade), Order = 2, TypeName = "decimal(3,2)")]
	public double? Grade { get; set; }
}

