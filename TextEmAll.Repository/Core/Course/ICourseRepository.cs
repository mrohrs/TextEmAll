namespace TextEmAll.Repository.Core;

public interface ICourseRepository
{
	/// <summary>
	/// Gets a Course by Primary Key
	/// </summary>
	/// <param name="courseId">The Primary Key for Course</param>
	/// <returns>A Course <see cref="Course"/></returns>
	Task<Course> Get(int courseId);
}
