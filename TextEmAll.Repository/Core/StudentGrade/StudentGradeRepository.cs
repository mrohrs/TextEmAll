namespace TextEmAll.Repository.Core;

/// <summary>
/// Repository for StudentGrade Entity
/// </summary>
public class StudentGradeRepository : IStudentGradeRepository
{
	private readonly SchoolContext _context;

	/// <summary>
	/// Constructs a new StudentGrade Repository
	/// </summary>
	/// <param name="schoolContext">The School DB Context</param>
	public StudentGradeRepository(SchoolContext schoolContext)
	{
		_context = schoolContext ?? throw new ArgumentNullException(nameof(schoolContext), "School Context cannot be NULL");
	}

	/// <inheritdoc/>
	public async Task<StudentGrade> Get(int enrollmentId)
	{
		if (enrollmentId == default)
		{
			throw new ArgumentException("Enrollment Id must be greater than 0.", nameof(enrollmentId));
		}

		StudentGrade person = await _context.StudentGrades.FindAsync(enrollmentId);

		return person;
	}

	/// <inheritdoc/>
	public async Task<List<StudentGrade>> GetAll()
	{
		List<StudentGrade> studentGrades = await _context.StudentGrades.ToListAsync();

		return studentGrades;
	}

	/// <inheritdoc/>
	public async Task<List<StudentGrade>> GetByStudentId(int studentId)
	{
		if (studentId == default)
		{
			throw new ArgumentException("Student Id must be greater than 0.", nameof(studentId));
		}

		List<StudentGrade> studentGrades = await _context.StudentGrades
			.Where(studentGrade => studentGrade.StudentId == studentId)
			.ToListAsync();

		return studentGrades;
	}
}
