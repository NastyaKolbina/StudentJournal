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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace TestApp2.View
{
    /// <summary>
    /// Interaction logic for ExamView.xaml
    /// </summary>
    public partial class ExamView : Page
    {
        public ExamView()
        {
            InitializeComponent();
        }

        private void Prog_Checked(object sender, RoutedEventArgs e)
        {
            ExamFrame.Navigate(new Prog());
        }

        private void Web_Checked(object sender, RoutedEventArgs e)
        {
            ExamFrame.Navigate(new Web());
        }

        private void GD_Checked(object sender, RoutedEventArgs e)
        {
            ExamFrame.Navigate(new GraphicDesign());
        }
    }
}
