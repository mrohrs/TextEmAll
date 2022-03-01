namespace TextEmAll.Api.Modules;

/// <summary>
/// Module for Swagger Setup
/// </summary>
public static class SwaggerModule
{
	/// <summary>
	/// Register Swagger Components
	/// </summary>
	/// <param name="builder">The WebApplicationBuilder <see cref="WebApplicationBuilder"/></param>
	/// <returns>The update Web ApplicationBuilder</returns>
	public static WebApplicationBuilder RegisterSwagger(this WebApplicationBuilder builder)
	{
		builder.Services.AddEndpointsApiExplorer();
		builder.Services.AddSwaggerGen
			(
				options =>
				{
					OpenApiContact contact = new()
					{
						Name = "Mike Rohrs",
					};

					OpenApiInfo swaggerInfo = new()
					{
						Version = "v1",
						Title = "Text-Em-All Coding Challenge",
						Contact = contact
					};

					options.SwaggerDoc("v1", swaggerInfo);

					options.IncludeXmlComments(System.IO.Path.Combine(AppContext.BaseDirectory, "text-em-all.xml"));
				}
			);
		return builder;
	}
}
