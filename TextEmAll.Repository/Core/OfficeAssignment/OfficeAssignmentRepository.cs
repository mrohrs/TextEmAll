namespace TextEmAll.Repository.Core;

/// <summary>
/// Repository for OfficeAssignment Entity
/// </summary>
public class OfficeAssignmentRepository : IOfficeAssignmentRepository
{
	private readonly SchoolContext _context;

	/// <summary>
	/// Constructs a new Office Assignment Repository 
	/// </summary>
	/// <param name="schoolContext">The School DB Context</param>
	public OfficeAssignmentRepository(SchoolContext schoolContext)
	{
		_context = schoolContext ?? throw new ArgumentNullException(nameof(schoolContext), "School Context cannot be NULL");
	}

	/// <inheritdoc/>
	public async Task<OfficeAssignment> Get(int instructorId)
	{
		if (instructorId == default)
		{
			throw new ArgumentException("Deparment Id must be greater than 0", nameof(instructorId));
		}

		OfficeAssignment officeAssignment = await _context.OfficeAssignments
						.FindAsync(instructorId);

		return officeAssignment;
	}
}
