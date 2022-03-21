using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Data;

namespace TestApp2.ViewModel
{
    public class ExamViewModel:INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string propName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propName));
        }
    }
}
