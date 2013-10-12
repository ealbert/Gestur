


using Gestur.Core.DependencyInjection;
using Gestur.Server.App.AppServices;
using Spring.Context.Support;

namespace Gestur.Core.Di.Spring
{
  public class Container : IContainer
  {
    public static XmlApplicationContext AppContext { get; set; }

    public void Initialise(string configFile)
    {
      AppContext = new XmlApplicationContext(configFile);
    }

    public static IRequestContext RequestContext { get; set; }
  }
}
