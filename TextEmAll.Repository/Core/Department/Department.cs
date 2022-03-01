namespace TextEmAll.Repository.Core;

/// <summary>
/// Department Entity Model
/// </summary>
[Table("Department")]
public class Department
{
	/// <summary>
	/// Primary Key to Department Table
	/// </summary>
	[Key]
	[Column(name: nameof(DepartmentId), Order = 1, TypeName = "int")]
	[Required(ErrorMessage = "Department Id is a required field")]
	public int DepartmentId { get; set; }

	/// <summary>
	/// Department Name
	/// </summary>
	[Column(name: nameof(Name), Order = 2, TypeName = "nvarchar(100)")]
	[Required(AllowEmptyStrings = false, ErrorMessage = "Title is a required field")]
	public string Name { get; set; }

	/// <summary>
	/// Department Budget Amount
	/// </summary>
	[Column(name: nameof(Budget), Order = 3, TypeName = "money")]
	[Required(ErrorMessage = "Budget is a required field")]
	public double Budget { get; set; }

	/// <summary>
	/// Department Start Date
	/// </summary>
	[Column(name: nameof(StartDate), Order = 4, TypeName = "date")]
	[Required(ErrorMessage = "StartDate is a required field")]
	public DateTime StartDate { get; set; }

	/// <summary>
	/// Department Administrator (If Applicable)
	/// </summary>
	[Column(name: nameof(Administrator), Order = 4, TypeName = "int")]
	public int? Administrator { get; set; }
}

