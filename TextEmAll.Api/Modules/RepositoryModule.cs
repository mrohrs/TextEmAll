namespace TextEmAll.Api.Modules;

/// <summary>
/// Module for Repository Setup
/// </summary>
public static class RepositoryModule
{
	/// <summary>
	/// Register Repository Classes
	/// </summary>
	/// <param name="builder">The WebApplicationBuilder <see cref="WebApplicationBuilder"/></param>
	/// <returns>The update Web ApplicationBuilder</returns>
	public static WebApplicationBuilder RegisterRepositories(this WebApplicationBuilder builder)
	{
		builder.Services.AddScoped<ICourseRepository, CourseRepository>();
		builder.Services.AddScoped<IPersonRepository, PersonRepository>();
		builder.Services.AddScoped<IStudentGradeRepository, StudentGradeRepository>();
		builder.Services.AddScoped<IDepartmentRepository, DepartmentRepository>();
		builder.Services.AddScoped<ICourseInstructorRepository, CourseInstructorRepository>();
		builder.Services.AddScoped<IOfficeAssignmentRepository, OfficeAssignmentRepository>();
		builder.Services.AddScoped<IOnlineCourseRepository, OnlineCourseRepository>();
		builder.Services.AddScoped<IOnsiteCourseRepository, OnsiteCourseRepository>();

		return builder;
	}
}
