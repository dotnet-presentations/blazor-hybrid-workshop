namespace MonkeyFinderHybrid.Model;

public class RatingState
{
	public Dictionary<Monkey, int> MonkeyRatings { get; } = [];
	public event EventHandler? RatingChanged;

	public void AddOrUpdateRating(Monkey monkey, int value)
	{
		if (!MonkeyRatings.TryAdd(monkey, value))
		{
			MonkeyRatings[monkey] = value;
		}

		RatingChanged?.Invoke(this, EventArgs.Empty);
	}

	public int GetRating(Monkey monkey)
	{
		if (MonkeyRatings.TryGetValue(monkey, out var rating))
		{
			return rating;
		}

		return 0;
	}
}
