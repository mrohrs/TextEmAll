namespace TextEmAll.Repository.Core
{
	/// <summary>
	/// Interface for Person Repository
	/// </summary>
	public interface IPersonRepository
	{
		/// <summary>
		/// Gets a Person by Primary Key
		/// </summary>
		/// <param name="personId">The Person Id <see cref="int"/></param>
		/// <returns>A Person Entity <see cref="Person"/></returns>
		Task<Person> Get(int personId);

		/// <summary>
		/// Gets all Persons
		/// </summary>
		/// <returns>A List of Person Entities <see cref="List{Person}"/></returns>
		Task<List<Person>> GetAll();

		/// <summary>
		/// Gets all Students
		/// </summary>
		/// <returns>A List of Person Entities <see cref="List{Person}"/></returns>
		Task<List<Person>> GetStudents();

		/// <summary>
		/// Gets all Instructors
		/// </summary>
		/// <returns>A List of Person Entities <see cref="List{Person}"/></returns>
		Task<List<Person>> GetInstructors();
	}
}