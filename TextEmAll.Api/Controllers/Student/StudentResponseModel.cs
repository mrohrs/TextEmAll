namespace TextEmAll.Api.Controllers;

/// <summary>
/// Person Entity Model
/// </summary>
public class StudentResponseModel
{
	/// <summary>
	/// Primary Key of Person
	/// </summary>
	public int StudentId { get; set; }

	/// <summary>
	/// Student's First Name
	/// </summary>
	public string FirstName { get; set; }

	/// <summary>
	/// Student's Last Name
	/// </summary>
	public string LastName { get; set; }

	/// <summary>
	/// Student's Grade Point Average (GPA)
	/// </summary>
	public double Gpa { get; set; }
}
