namespace TextEmAll.Repository.Core;

/// <summary>
/// CourseInstructor Entity Model
/// </summary>
[Table("CourseInstructor")]
public class CourseInstructor
{
	/// <summary>
	/// Foreign Key to Course Table
	/// </summary>
	[Column(name: nameof(CourseId), Order = 0, TypeName = "int")]
	[Required(ErrorMessage = "Course Id is a required field")]
	public int CourseId { get; set; }

	/// <summary>
	/// Foreign Key to Person Table
	/// </summary>
	[Column(name: nameof(PersonId), Order = 1, TypeName = "int")]
	[Required(ErrorMessage = "Person Id is a required field")]
	public int PersonId { get; set; }
}
