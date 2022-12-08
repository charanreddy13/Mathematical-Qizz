using Mathematical_Qizz.services;
using Mathematical_Qizz.pages;
using Mathematical_Qizz.viewmodel;

namespace Mathematical_Qizz;

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
			});
        builder.Services.AddSingleton<Loginpage>();
        builder.Services.AddSingleton<Iloginrepository, loginservice>();
        builder.Services.AddSingleton<loginpageviewmodel>();
        builder.Services.AddSingleton<register>();
        builder.Services.AddSingleton<scoreboard>();
        builder.Services.AddSingleton<Exercise>();
        return builder.Build();
	}
}
