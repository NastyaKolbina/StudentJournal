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
using System.Data.Entity;
using TestApp2.View;

namespace TestApp2.View
{
    /// <summary>
    /// Interaction logic for AttendView.xaml
    /// </summary>
    public partial class AttendView : Page
    {
        wpfCrud1Entities _dbA=new wpfCrud1Entities();

        public AttendView()
        {
            InitializeComponent();
        }


        private void StudName_MouseDown(object sender, MouseButtonEventArgs e)
        {
            NameTeach.Focus();
        }

        private void NameStud_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (!string.IsNullOrEmpty(NameTeach.Text) && NameTeach.Text.Length > 0)
            {
                TeachName.Visibility = Visibility.Collapsed;
            }
            else
            {
                TeachName.Visibility = Visibility.Visible;
            }
        }
        private void GroupName_MouseDown(object sender, MouseButtonEventArgs e)
        {
            NameGroup.Focus();
        }
        private void NameGroup_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (!string.IsNullOrEmpty(NameGroup.Text) && NameGroup.Text.Length > 0)
            {
                GroupName.Visibility = Visibility.Collapsed;
            }
            else
            {
                GroupName.Visibility = Visibility.Visible;
            }
        }

        private void date_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Data.Focus();
        }
        private void Data_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (!string.IsNullOrEmpty(Data.Text) && Data.Text.Length > 0)
            {
                date.Visibility = Visibility.Collapsed;
            }
            else
            {
                date.Visibility = Visibility.Visible;
            }
        }

        private void theme_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Theme.Focus();
        }
        private void Theme_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (!string.IsNullOrEmpty(Theme.Text) && Theme.Text.Length > 0)
            {
                theme.Visibility = Visibility.Collapsed;
            }
            else
            {
                theme.Visibility = Visibility.Visible;
            }
        }
        private void Notes_MouseDown(object sender, MouseButtonEventArgs e)
        {
            notes.Focus();
        }
        private void notes_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (!string.IsNullOrEmpty(notes.Text) && notes.Text.Length > 0)
            {
                Notes.Visibility = Visibility.Collapsed;
            }
            else
            {
                Notes.Visibility = Visibility.Visible;
            }
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(Theme.Text) || Theme.Text.Length>0 || !string.IsNullOrEmpty(Data.Text) || !string.IsNullOrEmpty(NameTeach.Text) || !string.IsNullOrEmpty(NameGroup.Text)
                || !string.IsNullOrEmpty(notes.Text))
            {
                attend newMember = new attend()
                {
                    teachName = NameTeach.Text,
                    groupname = NameGroup.Text,
                    date = Data.Text,
                    theme = Theme.Text,
                    notes = notes.Text

                };
                _dbA.attends.Add(newMember);
                _dbA.SaveChanges();
                
            }
            else
            {
                MessageBox.Show("Enter all fields");
            }
            
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var newWind = new TableAttend();
            newWind.Show();
            
        }

    }
}
