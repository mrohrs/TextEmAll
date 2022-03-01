namespace TextEmAll.Repository.Core
{
	/// <summary>
	/// Interface for Student Repository
	/// </summary>
	public interface IStudentGradeRepository
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="enrollmentId"></param>
		/// <returns>A StudentGrade Entity <see cref="StudentGrade"/></returns>
		Task<StudentGrade> Get(int enrollmentId);
		
		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		Task<List<StudentGrade>> GetAll();

		/// <summary>
		/// 
		/// </summary>
		/// <param name="studentId"></param>
		/// <returns></returns>
		Task<List<StudentGrade>> GetByStudentId(int studentId);
	}
}