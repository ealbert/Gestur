using System.Windows;
using System.Windows.Input;

namespace Gestur.wpf.client.ExceptionNotifier.View
{
    /// <summary>
    /// Interaction logic for ExceptionNotifier.xaml
    /// </summary>
    public partial class ExceptionNotifierView : Window
    {
        public ExceptionNotifierView()
        {
            InitializeComponent();
        }

        private void WindowLoaded(object sender, RoutedEventArgs e)
        {
            Keyboard.Focus(BtnClose);
        }
    }
}
