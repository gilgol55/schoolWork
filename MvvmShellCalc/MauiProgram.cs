using Microsoft.Extensions.Logging;
using MvvmShellCalc.ViewModels;
using MvvmShellCalc.Views;

namespace MvvmShellCalc;

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
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			}).RegisterPages();

//#if DEBUG
//		builder.Logging.AddDebug();
//#endif

		return builder.Build();
	}
	public static MauiAppBuilder RegisterPages(this MauiAppBuilder builder)
	{
		builder.Services.AddTransient<HistoryPage>();
		builder.Services.AddTransient<HistoryPageViewModels>();

		builder.Services.AddSingleton<CalcPage>();
		builder.Services.AddSingleton<CalcPageViewModel>();

		return builder;
	}
}
