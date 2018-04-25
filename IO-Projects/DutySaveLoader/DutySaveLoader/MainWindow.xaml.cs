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

namespace DutySaveLoader
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            var duties = new List<Duty>();

            var startDuty = new Duty {Id = 1, Name = "Early", StartTime = DateTime.Today.AddHours(6)};

            duties.Add(startDuty);

            dataGrid.ItemsSource = duties;
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void dataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Duty duty = (Duty) dataGrid.SelectedItem;


        }
    }
}
