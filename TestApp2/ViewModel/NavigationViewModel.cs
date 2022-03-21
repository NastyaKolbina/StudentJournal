using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Data;
using System.Windows.Input;

namespace TestApp2.ViewModel
{
    class NavigationViewModel:INotifyPropertyChanged
    {

        // Implement interface member for INotifyPropertyChanged.
        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string propName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propName));
        }

        private object _selectedViewModel;
        public object SelectedViewModel
        {
            get => _selectedViewModel;
            set { _selectedViewModel = value; OnPropertyChanged("SelectedViewModel"); }
        }

        public void SwitchViews(object parameter)
        {
            switch (parameter)
            {
                case "Home":
                    SelectedViewModel = new HomeViewModel();
                    break;
                case "Students":
                    SelectedViewModel = new StudentsViewModel();
                    break;
                case "Exam":
                    SelectedViewModel = new ExamViewModel();
                    break;
                case "Calendar":
                    SelectedViewModel = new CalendarViewModel();
                    break;
                case "Settings":
                    SelectedViewModel = new SettingsViewModel();
                    break;
                default:
                    SelectedViewModel = new HomeViewModel();
                    break;
            }
        }




    }
}
