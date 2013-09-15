using System;
using System.Windows.Input;

namespace Gestur.Core.Wpf.Util
{
  public class RelayCommand
    : ICommand
  {
    #region Fields

    readonly Action<object> _executeInstance;
    readonly Predicate<object> _canExecuteInstance;

    #endregion Fields

    #region Constructors

    public RelayCommand(Action<object> execute)
      : this(execute, null)
    {
    }

    public RelayCommand(Action<object> execute, Predicate<object> canExecute)
    {
      if (execute == null) throw new ArgumentNullException("execute");
      _executeInstance = execute;
      _canExecuteInstance = canExecute;
    }

    #endregion Constructors

    #region ICommand Members

    public bool CanExecute(object parameter)
    {
      return _canExecuteInstance == null || _canExecuteInstance(parameter);
    }

    public event EventHandler CanExecuteChanged
    {
      add { CommandManager.RequerySuggested += value; }
      remove { CommandManager.RequerySuggested -= value; }
    }

    public void Execute(object parameter)
    {
      _executeInstance(parameter);
    }

    #endregion ICommand Members
  }
}
