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
    /// Interaction logic for StudentsView.xaml
    /// </summary>
    public partial class StudentsView : Page
    {
        wpfCrudEntities _db=new wpfCrudEntities();
        public static DataGrid dataGrid;
        public StudentsView()
        {
            InitializeComponent();

            Load();

        }
        private void Load()
        {
            Dg.ItemsSource = _db.members.ToList();
            dataGrid = Dg;
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            //AddStudent Ipage=new AddStudent();
            //Ipage.ShowDialog();
            var newWindow = new AddStudent();
            newWindow.Show();
            
        }

        private void Del_Click(object sender, RoutedEventArgs e)
        {
            int Id = (Dg.SelectedItem as member).id;

            var DeleteMember = _db.members.Where(m => m.id == Id).Single();
            _db.members.Remove(DeleteMember);
            _db.SaveChanges();
            Dg.ItemsSource = _db.members.ToList();
        }

        public void Page_Loaded(object sender, RoutedEventArgs e)
        {


        }
    }
}
