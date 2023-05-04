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
using Ex1.Model;
using Ex1.Pages;

namespace Ex1.Pages
{
    /// <summary>
    /// Логика взаимодействия для AnimPage.xaml
    /// </summary>
    public partial class AnimPage : Page
    {
        public AnimPage()
        {
            InitializeComponent();
            Animal.ItemsSource = App.db.Animal.ToList();
        }

        private void CreateBtn_Click(object sender, RoutedEventArgs e)
        {
            
        }
        private void DiscountSortCb_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void SortCb_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new CompanyPage());
        }
    }
}
