using System.Windows;
using System.Windows.Threading;
using Elysium;
using Gestur.Core.Wpf.Exceptions;
using Gestur.wpf.client.BootStrapper;
using Gestur.wpf.client.ExceptionNotifier.ViewModel;

namespace Gestur.wpf.client
{
  /// <summary>
  /// Interaction logic for App.xaml
  /// </summary>
  public partial class App
  {
    public App()
    {
      ShutdownMode = ShutdownMode.OnExplicitShutdown;
    }


    protected override void OnStartup(StartupEventArgs e)
    {
      Current.DispatcherUnhandledException += AppDispatcherUnhandledException;
      base.OnStartup(e);
    }

    protected override void OnExit(ExitEventArgs e)
    {
      Current.DispatcherUnhandledException -= AppDispatcherUnhandledException;
      base.OnExit(e);
    }

    private void AppDispatcherUnhandledException(object sender, DispatcherUnhandledExceptionEventArgs e)
    {
      e.Handled = true;
      if (e.Exception is SuspendProcessException) { return; }
// ReSharper disable ObjectCreationAsStatement
      new ExceptionNotifierViewModel(e.Exception);
// ReSharper restore ObjectCreationAsStatement
    }

    private void App_OnStartup(object sender, StartupEventArgs e)
    {
      var boot = new AppBootStrapper();
      boot.Run();
      this.Apply(Theme.Dark);
      Shutdown();
    }
  }
}
