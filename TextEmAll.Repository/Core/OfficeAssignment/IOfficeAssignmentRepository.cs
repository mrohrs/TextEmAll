namespace TextEmAll.Repository.Core;

/// <summary>
/// Interface for OfficeAssignment Repository
/// </summary>
public interface IOfficeAssignmentRepository
{
	/// <summary>
	/// Gets an OfficeAssignment by Primary Key
	/// </summary>
	/// <param name="instructorId">The Instructor Id <see cref="int"/></param>
	/// <returns>An OfficeAssignment Entity <see cref="OfficeAssignment"/></returns>
	Task<OfficeAssignment> Get(int instructorId);
}
