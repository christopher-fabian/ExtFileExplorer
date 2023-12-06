using ExtFileExplorer.Disks;
using ExtFileExplorer.Files;
using ExtFileExplorer.ViewModels;
using ExtFileExplorer.Views;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Windows.Forms;

namespace ExtFileExplorer;

internal static class Program
{
  [STAThread]
  private static void Main()
  {
    AppDomain.CurrentDomain.UnhandledException += CurrentDomain_UnhandledException;

    ApplicationConfiguration.Initialize();

    IHost host = Host.CreateDefaultBuilder()
      .ConfigureAppConfiguration((context, builder) =>
      {
        //builder.AddJsonFile("appsettings.json");
      })
      .ConfigureServices((context, services) =>
      {
        ConfigureServices(services);
      })
      .ConfigureLogging(logging =>
      {
        // ToDo
      })
      .Build();

    MainForm mainForm = host.Services.GetRequiredService<MainForm>();
    Application.Run(mainForm);
  }

  private static void ConfigureServices(IServiceCollection services)
    => services.AddTransient<MainForm>()
        .AddTransient<MainViewModel>()
        .AddSingleton<IExtFileService, ExtFileService>()
        .AddSingleton<IDiskService, DiskService>();

  private static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
  {
    Exception exception = (Exception)e.ExceptionObject;
    MessageBox.Show(exception.ToString(), "Unhandled Exception");

    // ToDo: Log exception
  }
}
