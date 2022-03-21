using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using TestApp2.View;

namespace TestApp2
{
    /// <summary>
    /// Interaction logic for SecondWindow.xaml
    /// </summary>
    public partial class SecondWindow : Window
    {
        public SecondWindow()
        {
            InitializeComponent();
        }
        private void Home_Checked(object sender, RoutedEventArgs e)
        {
            frame.Navigate(new HomeView());
        }

        private void Students_Checked(object sender, RoutedEventArgs e)
        {
            frame.Navigate(new StudentsView());
        }

        private void Exam_Checked(object sender, RoutedEventArgs e)
        {
            frame.Navigate(new ExamView()); 
        }

        private void Exit_Checked(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Attendance_Checked(object sender, RoutedEventArgs e)
        {
            frame.Navigate(new AttendView());
        }
    }
}
