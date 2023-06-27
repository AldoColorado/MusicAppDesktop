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

namespace FEiMusic.View
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Application.Current.MainWindow = this;
            Loaded += OnMainWindowLoaded;
        }

        public void ChangeView(Page view)
        {
            //if (view is Login)
                //Sesion.CloseSesion();
            FrameContent.NavigationService.Navigate(view);
        }

        private void OnMainWindowLoaded(object sender, RoutedEventArgs e)
        {
            ChangeView(new Login());
        }
    }
}
