using System.ComponentModel;

namespace NewsXamPackt.ViewModels
{
    public abstract class ViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

    }
}
