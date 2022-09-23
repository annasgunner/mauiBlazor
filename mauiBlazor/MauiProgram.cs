using Microsoft.AspNetCore.Components.WebView.Maui;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Maui.Controls.Hosting;
using Microsoft.Maui.Hosting;
using mauiBlazor.Container;
using mauiBlazor.Data;
using Radzen;
//using DevExpress.Blazor.Reporting.Services;

namespace mauiBlazor;

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

            });

		builder.Services.AddMauiBlazorWebView();
        builder.Services.AddBlazorWebView();
#if DEBUG
        builder.Services.AddBlazorWebViewDeveloperTools();
#endif
        builder.Services.AddSingleton<WeatherForecastService>();
        builder.Services.AddSingleton<CustomerService>();
        builder.Services.AddSingleton<ReportService>();
        builder.Services.AddSingleton<DataService>();
        builder.Services.AddDevExpressBlazor(configure => configure.BootstrapVersion = DevExpress.Blazor.BootstrapVersion.v5);
		builder.Services.AddScoped<DialogService>();
        builder.Services.AddScoped<NotificationService>();
        builder.Services.AddScoped<TooltipService>();
        builder.Services.AddScoped<ContextMenuService>();


        //builder.Services.AddDevExpressServerSideBlazorReportViewer();
        //builder.Services.AddHttpContextAccessor();

        //builder.UseDevExpressServerSideBlazorReportViewer();

        return builder.Build();
		
        //app.UseDevExpressServerSideBlazorReportViewer();
		
    }
}
