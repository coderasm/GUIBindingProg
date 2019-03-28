using System.ComponentModel;

namespace WPFBindingProg
{
  class ViewModel : INotifyPropertyChanged
  {
    private string _text = "";
    public event PropertyChangedEventHandler PropertyChanged;
    public string Text {
      get
      {
        return _text;
      }
      set
      {
        if(_text != value)
        {
          _text = value;
          RaisePropertyChanged("Text");
        }
      }
    }

    public ViewModel()
    {
    }

    private void RaisePropertyChanged(string propertyName)
    {
      // take a copy to prevent thread issues
      PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }

  }
}
