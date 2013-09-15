using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestur.Core.DependencyInjection
{
  public interface IContainer
  {
    void Initialise(string configFile);
  }
}
