namespace TextEmAll.Repository.Core;

/// <summary>
/// Repository for CourseInstructor Entity
/// </summary>
public class CourseInstructorRepository : ICourseInstructorRepository
{
	private readonly SchoolContext _context;

	/// <summary>
	/// Constructs a new Course Instructor Repository
	/// </summary>
	/// <param name="schoolContext">The School DB Context</param>
	public CourseInstructorRepository(SchoolContext schoolContext)
	{
		_context = schoolContext ?? throw new ArgumentNullException(nameof(schoolContext), "School Context cannot be NULL");
	}

	/// <inheritdoc/>
	public async Task<CourseInstructor> Get(int courseId, int personId)
	{
		if (courseId == default)
		{
			throw new ArgumentException("Course Id must be greater than 0", nameof(courseId));
		}

		if (personId == default)
		{
			throw new ArgumentException("Person Id must be greater than 0", nameof(personId));
		}

		CourseInstructor courseInstructor = await _context.CourseInstructors
			.FindAsync(courseId, personId);

		return courseInstructor;
	}
}
