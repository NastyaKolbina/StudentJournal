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
    /// Interaction logic for TableAttend.xaml
    /// </summary>
    public partial class TableAttend : Window
    {
        wpfCrud1Entities _dbA = new wpfCrud1Entities();
        public static DataGrid dataGrid;
        public TableAttend()
        {
            InitializeComponent();

            Load();
        }

        private void Load()
        {
            Dgrid.ItemsSource = _dbA.attends.ToList();
            dataGrid = Dgrid;
        }
    }
}
