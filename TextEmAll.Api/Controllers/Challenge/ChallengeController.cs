namespace TextEmAll.Api.Controllers;

/// <summary>
/// Challenge Controller
/// </summary>
[Route("api")]
[ApiController]
public class ChallengeController : ControllerBase
{
	/// <summary>
	/// Gets the Maximum Distance between any two adjacent letters in the input string
	/// </summary>
	/// <param name="input">The string input</param>
	/// <returns>The Max Distance between a pair of letters as an integer value <see cref="int"/></returns>
	/// <response code="200">Returns the Max Distance <see cref="int"/> </response>
	/// <response code="400">Input was invalid and Max Distance could not be calculated.</response>
	/// <response code="500">An Internal Server Error was Encountered.</response>
	[HttpGet("challenge/maxdistance/{input}")]
	public IActionResult GetMaxDistance([FromRoute] string input)
	{
		if (string.IsNullOrWhiteSpace(input))
		{
			return BadRequest("Input cannot be NULL or containt white space.");
		}

		if (!input.All(Char.IsLetter))
		{
			return BadRequest("Input must contain only letters.");
		}

		int maxDistance = Challenge2.MaxDistance(input);

		return Ok(maxDistance);
	}
}

