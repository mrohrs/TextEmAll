namespace TextEmAll.Repository.Core;

/// <summary>
/// OnlineCourse Entity Model
/// </summary>
[Table("OnlineCourse")]
public class OnlineCourse
{
	/// <summary>
	/// Primary Key for Online Course Table
	/// </summary>
	[Key]
	[Column(name: nameof(CourseId), Order = 0, TypeName = "int")]
	[Required(ErrorMessage = "Course Id is a required field")]
	public int CourseId { get; set; }

	/// <summary>
	/// Online Course URL
	/// </summary>
	[Column(name: "URL", Order = 2, TypeName = "nvarchar(100)")]
	[Required(AllowEmptyStrings = false, ErrorMessage = "URL is a required field")]
	public string Url { get; set; }
}
