namespace TextEmAll.Repository.Core;

/// <summary>
/// Repository for Course Entity
/// </summary>
public class CourseRepository : ICourseRepository
{
	private readonly SchoolContext _context;

	/// <summary>
	/// Constructs a new Course Repository
	/// </summary>
	/// <param name="schoolContext">The School DB Context</param>
	public CourseRepository(SchoolContext schoolContext)
	{
		_context = schoolContext ?? throw new ArgumentNullException(nameof(schoolContext), "School Context cannot be NULL");
	}

	/// <inheritdoc/>
	public async Task<Course> Get(int courseId)
	{
		if (courseId == default)
		{
			throw new ArgumentException("Course Id must be greater than 0", nameof(courseId));
		}

		Course course = await _context.Courses
			.FindAsync(courseId);

		return course;
	}
}
