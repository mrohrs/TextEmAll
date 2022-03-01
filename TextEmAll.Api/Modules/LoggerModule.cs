namespace TextEmAll.Api.Modules;

/// <summary>
/// Module for Logger Setup
/// </summary>
public static class LoggerModule
{
	/// <summary>
	/// Register Repository Classes
	/// </summary>
	/// <param name="builder">The WebApplicationBuilder <see cref="WebApplicationBuilder"/></param>
	/// <returns>The update Web ApplicationBuilder</returns>
	public static WebApplicationBuilder RegisterLoggers(this WebApplicationBuilder builder)
	{

		LoggerFactory.Create
		(
			builder =>
			{
				builder.AddConsole();
			}
		);

		return builder;
	}
}
