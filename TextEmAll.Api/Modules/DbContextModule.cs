namespace TextEmAll.Api.Modules;

/// <summary>
/// Module for Database Context Setup
/// </summary>
public static class DbContextModule
{
	/// <summary>
	/// Register Database Contexts
	/// </summary>
	/// <param name="builder">The WebApplicationBuilder <see cref="WebApplicationBuilder"/></param>
	/// <returns>The update Web ApplicationBuilder</returns>
	public static WebApplicationBuilder RegisterDbContexts(this WebApplicationBuilder builder)
	{
		// Get Connection string
		var connectionString = builder.Configuration.GetConnectionString("SchoolDatabase");

		// Add School Database Context
		builder.Services.AddDbContext<SchoolContext>(x => x.UseSqlServer(connectionString));

		return builder;
	}
}
