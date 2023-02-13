namespace CodeQuotes;

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
				fonts.AddFont("Bison.ttf", "Bison");
				fonts.AddFont("Poppins-BoldItalic.ttf", "PoppinsB");
				fonts.AddFont("Poppins-Italic.ttf", "PoppinsI");
			});

		return builder.Build();
	}
}
