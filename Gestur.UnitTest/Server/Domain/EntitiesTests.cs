using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gestur.Server.Domain.Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Gestur.UnitTest.Server.Domain
{
  [TestClass]
  public class EntitiesTests
  {
    [TestMethod]
    public void AutoMapper()
    {
      AutoMapperConfigurator.TestMappings();
    }
  }
}
