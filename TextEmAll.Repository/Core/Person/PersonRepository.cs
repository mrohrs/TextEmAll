namespace TextEmAll.Repository.Core;

/// <summary>
/// Repository for Person Entity
/// </summary>
public class PersonRepository : IPersonRepository
{
	private readonly SchoolContext _context;

	/// <summary>
	/// Constructs a new Course Repository
	/// </summary>
	/// <param name="schoolContext">The School DB Context</param>
	public PersonRepository(SchoolContext schoolContext)
	{
		_context = schoolContext ?? throw new ArgumentNullException(nameof(schoolContext), "School Context cannot be NULL");
	}

	/// <inheritdoc/>
	public async Task<Person> Get(int personId)
	{
		if (personId == default)
		{
			throw new ArgumentException("Person Id must be greater than 0.", nameof(personId));
		}

		Person person = await _context.Persons
			.FindAsync(personId);	

		return person;
	}

	/// <inheritdoc/>
	public async Task<List<Person>> GetAll()
	{
		List<Person> persons = await _context.Persons
			.ToListAsync();

		return persons;
	}

	/// <inheritdoc/>
	public async Task<List<Person>> GetStudents()
	{
		List<Person> persons = await _context.Persons
			.Where(person => person.Discriminator == "Student")
			.ToListAsync();

		return persons;
	}

	/// <inheritdoc/>
	public async Task<List<Person>> GetInstructors()
	{
		List<Person> persons = await _context.Persons
			.ToListAsync();

		return persons;
	}
}
