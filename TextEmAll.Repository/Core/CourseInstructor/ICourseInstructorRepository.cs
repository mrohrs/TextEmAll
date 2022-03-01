namespace TextEmAll.Repository.Core;

/// <summary>
/// Interface for CourseInstructor Repository
/// </summary>
public interface ICourseInstructorRepository
{
	/// <summary>
	/// Gets a Course Instructor by Primary Keys
	/// </summary>
	/// <param name="courseId">The Course Id <see cref="int"/></param>
	/// <param name="personId">The Person Id <see cref="int"/></param>
	/// <returns>A Course Instructor Entity <see cref="CourseInstructor"/></returns>
	Task<CourseInstructor> Get(int courseId, int personId);
}
