namespace TextEmAll.Api.Controllers;

/// <summary>
/// The Student Controller
/// </summary>
[Route("api")]
[ApiController]
public class StudentController : ControllerBase
{
	public readonly SchoolContext _context;
	public readonly IPersonRepository _personRepository;
	public readonly IStudentGradeRepository _studentGradeRepository;

	/// <summary>
	/// Constructs a new instance of the StudentController
	/// </summary>
	/// <param name="context">The School Database Context <see cref="SchoolContext"/></param>
	/// <param name="personRepository">The Person Repository <see cref="IPersonRepository"/></param>
	/// <param name="studentGradeRepository">The Student Grade Repository <see cref="IStudentGradeRepository"/></param>
	public StudentController
	(
		SchoolContext context,
		IPersonRepository personRepository,
		IStudentGradeRepository studentGradeRepository
	)
	{
		_context = context ?? throw new ArgumentNullException(nameof(context), "School Context cannot be NULL");
		_personRepository = personRepository ?? throw new ArgumentNullException(nameof(personRepository), "Person Repository cannot be NULL");
		_studentGradeRepository = studentGradeRepository ?? throw new ArgumentNullException(nameof(studentGradeRepository), "Student Grade Repository cannot be NULL");
	}

	/// <summary>
	/// This endpoint Gets a list of Students with their GPA using a single LINQ query
	/// </summary>
	/// <returns>A list of Students and their GPA</returns>
	/// <response code="200">Returns a  List of Students and GPA <see cref="List{ StudentResponseModel }"/> </response>
	/// <response code="500">An Internal Server Error was Encountered.</response>
	[HttpGet("students")]
	public async Task<IActionResult> GetStudentsWithGpaSingleQuery()
	{
		List<StudentResponseModel> response = await
		(
			from studentGrade in _context.StudentGrades
			group studentGrade by studentGrade.StudentId into studentGradeGroup
			select new
			{
				StudentId = studentGradeGroup.Key,
				Gpa = studentGradeGroup.Average(studentGrade => studentGrade.Grade)
			} into studentGrade

			join person in _context.Persons
				on studentGrade.StudentId equals person.PersonId
			select new StudentResponseModel()
			{
				StudentId = studentGrade.StudentId,
				FirstName = person.FirstName,
				LastName = person.LastName,
				Gpa = studentGrade.Gpa ?? 0
			}
		)
		.OrderBy(student => student.StudentId)
		.ToListAsync();

		return Ok(response);
	}

	/// <summary>
	/// This endpoint Gets a list of Students with their GPA using calls into multiple repositories and aggregating the data
	/// </summary>
	/// <returns>A list of Students and their GPA</returns>
	/// <response code="200">Returns a List of Students and GPA <see cref="List{ StudentResponseModel }"/> </response>
	/// <response code="500">An Internal Server Error was Encountered.</response>
	[HttpGet("students2")]
	public async Task<IActionResult> GetStudentsWithGpaByOrchestration()
	{
		List<Person> students = await _personRepository.GetStudents();
		List<StudentGrade> studentGrades = await _studentGradeRepository.GetAll();

		List<StudentResponseModel> response = students
			.Select
			(
				student =>
				{
					double gpa = studentGrades
						.Where(grade => grade.StudentId == student.PersonId)
						.Average(gpa => gpa.Grade) ?? 0;

					return new StudentResponseModel()
					{
						StudentId = student.PersonId,
						FirstName = student.FirstName,
						LastName = student.LastName,
						Gpa = gpa
					};
				}
			)
			.OrderBy(student => student.StudentId)
			.ToList();

		return Ok(response);
	}
}