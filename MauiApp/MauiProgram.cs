using Microsoft.Extensions.Logging;

namespace $safeprojectname$;

public static class MauiProgram
{
	public static $safeprojectname$ CreateMauiApp()
	{
		var builder = $safeprojectname$.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});

#if DEBUG
		builder.Logging.AddDebug();
#endif

		return builder.Build();
	}
}
