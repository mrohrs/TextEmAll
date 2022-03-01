namespace TextEmAll.Repository.Core;

/// <summary>
/// OfficeAssignment Entity Model
/// </summary>
[Table("OfficeAssignment")]
public class OfficeAssignment
{
	/// <summary>
	/// Primary Key for OfficeAssignment Table
	/// </summary>
	[Key]
	[Column(name: nameof(InstructorId), Order = 0, TypeName = "int")]
	[Required(ErrorMessage = "Instructor Id is a required field")]
	public int InstructorId { get; set; }

	/// <summary>
	/// Office Assignment Location
	/// </summary>
	[Column(name: nameof(Location), Order = 2, TypeName = "nvarchar(50)")]
	[Required(AllowEmptyStrings = false, ErrorMessage = "Location is a required field")]
	public string Location { get; set; }

	/// <summary>
	/// Office Assignment Update Timestamp
	/// </summary>
	[Column(name: nameof(Timestamp), Order = 3, TypeName = "timestamp")]
	[Required(ErrorMessage = "Timestamp is a required field")]
	public byte[] Timestamp { get; set; }
}
