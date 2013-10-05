using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gestur.Core.Di.Spring;
using Gestur.wpf.client.UI.Main;
using Spring.Context.Support;

namespace Gestur.wpf.client.BootStrapper
{

  class AppBootStrapper
  {
    public void Run()
    {
      InitialiseDependencies();
      var viewModel = new MainViewModel();

    }

    private void InitialiseDependencies()
    {
      var spring = ConfigurationManager.AppSettings.Get("SpringConfigFile");
      Container.AppContext = new XmlApplicationContext(spring);
    }
  }
}
