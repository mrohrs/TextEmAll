

using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

using System.IO;

namespace TrainerSolutions.Api.General.Repository.Database;

[ExcludeFromCodeCoverage]
/// <summary>Database Context for School Database</summary>
public class SchoolContext : DbContext
{
	/// <summary>This is the constructor to build the dbcontext and inject the options</summary>
	/// <param name="options">Any additional options to set the dbcontext</param>
	public SchoolContext(DbContextOptions<SchoolContext> options) : base(options) { }

	/// <summary>
	/// <see cref="Course"/>
	/// </summary>
	public DbSet<Course> Courses { get; set; }

	/// <summary>
	/// <see cref="CourseInstructor"/>
	/// </summary>
	public DbSet<CourseInstructor> CourseInstructors { get; set; }

	/// <summary>
	/// <see cref="Department"/>
	/// </summary>
	public DbSet<Department> Departments { get; set; }

	/// <summary>
	/// <see cref="OfficeAssignment"/>
	/// </summary>
	public DbSet<OfficeAssignment> OfficeAssignments { get; set; }

	/// <summary>
	/// <see cref="OnlineCourse"/>
	/// </summary>
	public DbSet<OnlineCourse> OnlineCourses { get; set; }

	/// <summary>
	/// <see cref="OnsiteCourse"/>
	/// </summary>
	public DbSet<OnsiteCourse> OnsiteCourses { get; set; }

	/// <summary>
	/// <see cref="Person"/>
	/// </summary>
	public DbSet<Person> Persons { get; set; }

	/// <summary>
	/// <see cref="StudentGrade"/>
	/// </summary>
	public DbSet<StudentGrade> StudentGrades { get; set; }

	/// <summary>This is used to configure additional options for the dbcontext</summary>
	/// <param name="optionsBuilder"></param>
	protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
	{
	}

	/// <summary>This is used to add additional information for models</summary>
	/// <param name="modelBuilder"></param>
	protected override void OnModelCreating(ModelBuilder modelBuilder)
	{
		// Composite Key for CourseInstructors
		modelBuilder.Entity<CourseInstructor>()
			.HasKey(nameof(CourseInstructor.CourseId), nameof(CourseInstructor.PersonId));
	}
}
