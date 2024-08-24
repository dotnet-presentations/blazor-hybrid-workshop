namespace MonkeyFinderHybrid.MauiPages;

public partial class MonkeyRatingPage : ContentPage
{
    private readonly RatingState ratingState;
    private readonly Monkey monkeyToRate;

	public MonkeyRatingPage(Monkey monkey, RatingState ratingState)
	{
		InitializeComponent();

		this.ratingState = ratingState;
		monkeyToRate = monkey;
		rating.Value = ratingState.GetRating(monkey);
	}

	protected override void OnNavigatedFrom(NavigatedFromEventArgs args)
	{
		base.OnNavigatedFrom(args);

		ratingState.AddOrUpdateRating(monkeyToRate, rating.Value);
	}
}
