namespace Gestur.Core.Persistance.TransManager
{
  public interface ITransFactory
  {
    ITransManager CreateManager();
  }

}