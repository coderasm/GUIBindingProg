using System.Windows;

namespace WPFBindingProg
{
  /// <summary>
  /// Interaction logic for MainWindow.xaml
  /// </summary>
  public partial class MainWindow : Window
  {
    ViewModel viewModel = new ViewModel();
    public MainWindow()
    {
      InitializeComponent();
      DataContext = viewModel;
    }

    private void Clear(object sender, RoutedEventArgs e)
    {
      viewModel.Text = "";
    }

    private void OpenDialog(object sender, RoutedEventArgs e)
    {
      var textToShow = "Nothing Entered!!";
      if (viewModel.Text != "")
        textToShow = viewModel.Text;
      MessageBox.Show(textToShow);
    }
  }
}
