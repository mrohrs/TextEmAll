namespace TextEmAll.Repository.Core;

/// <summary>
/// Interface for Department Repository
/// </summary>
public interface IDepartmentRepository
{
	/// <summary>
	/// Gets a Deparment by Primary Key
	/// </summary>
	/// <param name="departmentId">The Department Id <see cref="int"/></param>
	/// <returns>A Deparment Entity <see cref="Deparment"/></returns>
	Task<Department> Get(int departmentId);
}
