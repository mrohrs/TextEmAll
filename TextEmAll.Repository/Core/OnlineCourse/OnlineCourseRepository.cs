namespace TextEmAll.Repository.Core;

/// <summary>
/// Repository for OnlineCourse Entity
/// </summary>
public class OnlineCourseRepository : IOnlineCourseRepository
{
	private readonly SchoolContext _context;

	/// <summary>
	/// Constructs a new Online Course Repository 
	/// </summary>
	/// <param name="schoolContext">The School DB Context</param>
	public OnlineCourseRepository(SchoolContext schoolContext)
	{
		_context = schoolContext ?? throw new ArgumentNullException(nameof(schoolContext), "School Context cannot be NULL");
	}

	/// <inheritdoc/>
	public async Task<OnlineCourse> Get(int courseId)
	{
		if (courseId == default)
		{
			throw new ArgumentException("Course Id must be greater than 0", nameof(courseId));
		}

		OnlineCourse onlineCourse = await _context.OnlineCourses
			.FindAsync(courseId);

		return onlineCourse;
	}
}
