namespace TextEmAll.Repository.Core;

/// <summary>
/// Interface for OnsiteCourse Repository
/// </summary>
public interface IOnsiteCourseRepository
{
	/// <summary>
	/// Gets an OnsiteCourse by Primary Key
	/// </summary>
	/// <param name="courseId">The Course Id <see cref="int"/></param>
	/// <returns>An OnsiteCourse Entity <see cref="OnsiteCourse"/></returns>
	Task<OnsiteCourse> Get(int courseId);
}
