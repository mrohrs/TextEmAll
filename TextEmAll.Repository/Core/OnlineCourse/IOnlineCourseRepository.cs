namespace TextEmAll.Repository.Core;

/// <summary>
/// Interface for OnlineCourse Repository
/// </summary>
public interface IOnlineCourseRepository
{
	/// <summary>
	/// Gets an OnlineCourse by Primary Key
	/// </summary>
	/// <param name="courseId">The Course Id <see cref="int"/></param>
	/// <returns>An OnlineCourse Entity <see cref="OnlineCourse"/></returns>
	Task<OnlineCourse> Get(int courseId);
}
