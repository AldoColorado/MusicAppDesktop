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

namespace FEiMusic.View
{
    /// <summary>
    /// Lógica de interacción para MainMenu.xaml
    /// </summary>
    public partial class MainMenu : Window
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void CloseSesionButton_Clicked(object sender, RoutedEventArgs e)
        {
            //Sesion.CloseSesion();
            var mainWindow = (MainWindow)Application.Current.MainWindow;
            mainWindow?.ChangeView(new Login());
            return;
        }

        private void GridMain_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {

        }

        private void MenuToggleButton_Unchecked(object sender, RoutedEventArgs e)
        {

        }

        private void MenuToggleButton_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void ListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void ListViewItem_MouseEnter(object sender, MouseEventArgs e)
        {

        }
    }
}
