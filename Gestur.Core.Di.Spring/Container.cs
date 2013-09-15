


using Gestur.Core.DependencyInjection;
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
  }
}
