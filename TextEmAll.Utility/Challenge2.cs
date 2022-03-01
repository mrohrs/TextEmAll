namespace TextEmAll.Utility;

/// <summary>
/// Utility Methods for Challenge2
/// </summary>
public static class Challenge2
{
	/// <summary>
	/// Calculates the Maximum Distance between a pair of corresponding letters in the input string
	/// </summary>
	/// <param name="input">The string input</param>
	/// <returns>The Max Distance between a pair of letters as an integer value <see cref="int"/></returns>
	public static int MaxDistance(string input)
	{
		if (string.IsNullOrWhiteSpace(input))
		{
			throw new ArgumentException("Input cannot be NULL or containt white space.", nameof(input));	
		}

		if (!input.All(char.IsLetter))
		{
			throw new ArgumentException("Input must contain only letters.", nameof(input));
		}
			
		int maxDistance = 0;
		byte previousLetterValue = 0;

		input = input.ToLower();
			
		foreach (char letter in input)
		{
			byte letterValue = (byte)letter;

			if (previousLetterValue != 0)
			{
				if (letterValue > previousLetterValue)
				{
					int distance = letterValue - previousLetterValue;

					if (distance > maxDistance)
					{
						maxDistance = distance;
					}
				}
			}

			previousLetterValue = letterValue;
		}

		return maxDistance;
	}
}
