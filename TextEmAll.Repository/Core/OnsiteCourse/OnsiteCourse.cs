namespace TextEmAll.Repository.Core;

/// <summary>
/// OnsiteCourse Entity Model
/// </summary>
[Table("OnsiteCourse")]
public class OnsiteCourse
{
	/// <summary>
	/// Primary Key for OnsiteCourse Table
	/// </summary>
	[Key]
	[Column(name: nameof(CourseId), Order = 0, TypeName = "int")]
	[Required(ErrorMessage = "Course Id is a required field")]
	public int CourseId { get; set; }

	/// <summary>
	/// On Site Course Location
	/// </summary>
	[Column(name: nameof(Location), Order = 2, TypeName = "nvarchar(50)")]
	[Required(AllowEmptyStrings = false, ErrorMessage = "Location is a required field")]
	public string Location { get; set; }

	/// <summary>
	/// Days on which On Site Course is conducted
	/// </summary>
	[Column(name: nameof(Days), Order = 2, TypeName = "nvarchar(50)")]
	[Required(AllowEmptyStrings = false, ErrorMessage = "Days is a required field")]
	public string Days { get; set; }

	/// <summary>
	/// Time at which On Site Course is conducted
	/// </summary>
	[Column(name: nameof(Time), Order = 3, TypeName = "time(7)")]
	[Required(ErrorMessage = "Time is a required field")]
	public TimeSpan Time { get; set; }
}
