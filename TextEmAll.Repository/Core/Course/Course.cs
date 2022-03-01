namespace TextEmAll.Repository.Core;

/// <summary>
/// Course Entity Model
/// </summary>
[Table("Course")]
public class Course
{
	/// <summary>
	/// Primary Key for Course Table
	/// </summary>
	[Key]
	[Column(name: nameof(CourseId), Order = 0, TypeName = "int")]
	[Required(ErrorMessage = "Course Id is a required field")]
	public int CourseId { get; set; }

	/// <summary>
	/// Foreign Key to Department Table
	/// </summary>
	[ForeignKey("Department")]
	[Column(name: nameof(DepartmentId), Order = 1, TypeName = "int")]
	[Required(ErrorMessage = "Department Id is a required field")]
	public int DepartmentId { get; set; }

	/// <summary>
	/// Course Title
	/// </summary>
	[Column(name: nameof(Title), Order = 2, TypeName = "nvarchar(100)")]
	[Required(AllowEmptyStrings = false, ErrorMessage = "Title is a required field")]
	public string Title { get; set; }

	/// <summary>
	/// Number of Course Credits
	/// </summary>
	[Column(name: nameof(Credits), Order = 3, TypeName = "int")]
	[Required(ErrorMessage = "Credits is a required field")]
	public int Credits { get; set; }
}
