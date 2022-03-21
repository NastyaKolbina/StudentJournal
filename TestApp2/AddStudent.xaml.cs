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
using System.Data.Entity;
using TestApp2.View;


namespace TestApp2
{
    /// <summary>
    /// Interaction logic for AddStudent.xaml
    /// </summary>
    public partial class AddStudent : Window
    {

        wpfCrudEntities _db = new wpfCrudEntities();

        public AddStudent()
        {
            InitializeComponent();
        }

        private void StudName_MouseDown(object sender, MouseButtonEventArgs e)
        {
            NameStud.Focus();
        }

        private void NameStud_TextChanged(object sender, TextChangedEventArgs e)
        {
            if(!string.IsNullOrEmpty(NameStud.Text) && NameStud.Text.Length > 0){
                StudName.Visibility = Visibility.Collapsed;
            }
            else
            {
                StudName.Visibility = Visibility.Visible;
            }
        }

        private void Surname_MouseDown(object sender, MouseButtonEventArgs e)
        {
            SurName.Focus();
        }

        private void SurName_TextChanged(object sender, TextChangedEventArgs e)
        {
            if(!string.IsNullOrEmpty(Surname.Text) && Surname.Text.Length > 0)
            {
                Surname.Visibility = Visibility.Collapsed;
            }
            else
            {
                Surname.Visibility = Visibility.Visible;
            }
        }

        private void Number_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (!string.IsNullOrEmpty(Telephone.Text) && Telephone.Text.Length > 0)
            {
                Telephone.Visibility = Visibility.Collapsed;
            }
            else
            {
                Telephone.Visibility = Visibility.Visible;
            }
        }

        private void Telephone_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Number.Focus();
        }

        private void TeachName_MouseDown(object sender, MouseButtonEventArgs e)
        {
            NameTeach.Focus();
        }

        private void NameTeach_TextChanged(object sender, TextChangedEventArgs e)
        {
            if(!string.IsNullOrEmpty(TeachName.Text) && TeachName.Text.Length > 0)
            {
                TeachName.Visibility = Visibility.Collapsed;
            }
            else
            {
                TeachName.Visibility = Visibility.Visible;
            }
        }

        private void GrName_MouseDown(object sender, MouseButtonEventArgs e)
        {
            NameGr.Focus();
        }

        private void NameGr_TextChanged(object sender, TextChangedEventArgs e)
        {
            if(!string.IsNullOrEmpty(GrName.Text) && GrName.Text.Length > 0)
            {
                GrName.Visibility = Visibility.Collapsed;
            }
            else
            {
                GrName.Visibility = Visibility.Visible;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
            member newMember = new member()
            {
                name = NameStud.Text,
                surname = SurName.Text,
                telnum = Number.Text,
                teachname = NameTeach.Text,
                groupname = NameGr.Text

            };
            _db.members.Add(newMember);
            _db.SaveChanges();
            StudentsView.dataGrid.ItemsSource = _db.members.ToList();
            this.Close();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

        }
    }
}
