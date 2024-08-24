using Microsoft.Extensions.Logging;
using Microsoft.FluentUI.AspNetCore.Components;
using CommunityToolkit.Maui;

namespace MonkeyFinderHybrid;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
			})
			.UseMauiCommunityToolkit();

		builder.Services.AddMauiBlazorWebView();
		builder.Services.AddFluentUIComponents();

		builder.Services.AddSingleton<MonkeyService>();
		builder.Services.AddSingleton<IGeolocation>(sp => Geolocation.Default);
		builder.Services.AddSingleton<IMap>(sp => Map.Default);

#if DEBUG
        builder.Services.AddBlazorWebViewDeveloperTools();
		builder.Logging.AddDebug();
#endif

		return builder.Build();
	}
}
