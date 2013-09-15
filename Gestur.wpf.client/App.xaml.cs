using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Threading;
using Gestur.wpf.client.ExceptionNotifier.ViewModel;

namespace Gestur.wpf.client
{
  /// <summary>
  /// Interaction logic for App.xaml
  /// </summary>
  public partial class App : Application
  {
    public App()
    {
      ShutdownMode = ShutdownMode.OnExplicitShutdown;
    }

    private void BootStrapper(object sender, StartupEventArgs e)
    {
      var boot = new eDirectoryBootStrapper();
      boot.Run();
      Shutdown();
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
      new ExceptionNotifierViewModel(e.Exception);
    }
  }
}
