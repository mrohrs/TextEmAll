namespace TextEmAll.Repository.Core;

/// <summary>
/// Repository for OnsiteCourse Entity
/// </summary>
public class OnsiteCourseRepository : IOnsiteCourseRepository
{
	private readonly SchoolContext _context;

	/// <summary>
	/// Constructs a new Onsite Course Repository 
	/// </summary>
	/// <param name="schoolContext">The School DB Context</param>
	public OnsiteCourseRepository(SchoolContext schoolContext)
	{
		_context = schoolContext ?? throw new ArgumentNullException(nameof(schoolContext), "School Context cannot be NULL");
	}

	/// <inheritdoc/>
	public async Task<OnsiteCourse> Get(int courseId)
	{
		if (courseId == default)
		{
			throw new ArgumentException("Course Id must be greater than 0", nameof(courseId));
		}

		OnsiteCourse onsiteCourse = await _context.OnsiteCourses
			.FindAsync(courseId);

		return onsiteCourse;
	}
}
