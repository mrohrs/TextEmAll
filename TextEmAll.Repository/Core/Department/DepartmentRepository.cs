namespace TextEmAll.Repository.Core;

/// <summary>
/// Repository for Department Entity
/// </summary>
public class DepartmentRepository : IDepartmentRepository
{
	private readonly SchoolContext _context;

	/// <summary>
	/// Constructs a new Department Repository 
	/// </summary>
	/// <param name="schoolContext">The School DB Context</param>
	public DepartmentRepository(SchoolContext schoolContext)
	{
		_context = schoolContext ?? throw new ArgumentNullException(nameof(schoolContext), "School Context cannot be NULL");
	}

	/// <inheritdoc/>
	public async Task<Department> Get(int departmentId)
	{
		if (departmentId == default)
		{
			throw new ArgumentException("Deparment Id must be greater than 0", nameof(departmentId));
		}

		Department department = await _context.Departments
			.FindAsync(departmentId);

		return department;
	}
}
