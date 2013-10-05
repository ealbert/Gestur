using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gestur.Core.Wpf.Util;

namespace Gestur.wpf.client.UI.Main
{
  class MainViewModel
    :ViewModelBase
  {
    private readonly MainWindow _view;

    public MainViewModel()
    {
      _view = new MainWindow();
      _view.ShowDialog();
    }
  }
}
