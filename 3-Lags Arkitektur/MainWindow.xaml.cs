using BusinessLogic.BLL;
using DTO.Model;
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

namespace _3_Lags_Arkitektur
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

        CarBLL bll = new CarBLL();
        private void SearchButton_Click(object sender, RoutedEventArgs e)
        {
            Car c = bll.getCar(Int32.Parse(SearchId.Text));
            Navn.Content = c.Name;
            YearsEmployed.Content = c.ModelYear;
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            Car emp = new Car(7, NameToAdd.Text);
            emp.ModelYear = int.Parse(Years.Text);
            bll.AddCar(emp);
            Navn.Content = emp.Name;
            YearsEmployed.Content = emp.ModelYear;
        }

    }
}
