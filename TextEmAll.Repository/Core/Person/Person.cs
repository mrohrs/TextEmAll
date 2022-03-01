namespace TextEmAll.Repository.Core;

/// <summary>
/// Person Entity Model
/// </summary>
[Table("Person")]
public class Person
{
	/// <summary>
	/// Primary Key for Person Table
	/// </summary>
	[Key]
	[Column(name: nameof(PersonId), Order = 0, TypeName = "int")]
	[Required(ErrorMessage = "Person Id is a required field")]
	public int PersonId { get; set; }

	/// <summary>
	/// Person's Last Name
	/// </summary>
	[Column(name: nameof(LastName), Order = 1, TypeName = "nvarchar(50)")]
	[Required(AllowEmptyStrings = false, ErrorMessage = "LastName is a required field")]
	public string LastName { get; set; }

	/// <summary>
	/// Person's First Name
	/// </summary>
	[Column(name: nameof(FirstName), Order = 2, TypeName = "nvarchar(50)")]
	[Required(AllowEmptyStrings = false, ErrorMessage = "FirstName is a required field")]
	public string FirstName { get; set; }

	/// <summary>
	/// Date on which person was Hired (If Applicable)
	/// </summary>
	[Column(name: nameof(HireDate), Order = 3, TypeName = "date")]
	public DateTime? HireDate { get; set; }

	/// <summary>
	/// Date on which person was Enrolled (If Applicable)
	/// </summary>
	[Column(name: nameof(EnrollmentDate), Order = 4, TypeName = "date")]
	public DateTime? EnrollmentDate { get; set; }

	/// <summary>
	/// Determines the Table the Person Id is associated with
	/// </summary>
	[Column(name: nameof(Discriminator), Order = 5, TypeName = "varchar(50)")]
	public string Discriminator { get; set; }
}
