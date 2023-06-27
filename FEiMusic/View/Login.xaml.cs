using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using FEiMusic.Utilities;
using FEiMusic.Api;
using FEiMusic.Client;
using FEiMusic.Model;
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
    /// Lógica de interacción para Login.xaml
    public partial class Login : Page
    {
        public Login()
        {
            InitializeComponent();
        }

        private void LogInButton_Click(object sender, RoutedEventArgs e)
        {
            if (VerificateFields())
            {
                DefaultApi defaultApi = new DefaultApi();
                try
                {
                    LoginRequest loginRequest = new LoginRequest(userTextBox.Text, passwordTextBox.Password);

                    var response = defaultApi.LoginPost(loginRequest);

                    if (response.Status == "Success")
                    {
                        MainMenu mainMenuWindow = new MainMenu();
                        Window.GetWindow(this).Close();
                        mainMenuWindow.Show();
                    }
                    else
                    {
                        snackbar.MessageQueue.Enqueue(response.Status);
                    }
                }
                catch (ApiException ex)
                {
                    if (ex.ErrorCode == 404)
                        snackbar.MessageQueue.Enqueue("Usuario o contraseña incorrecta");
                }    
            }
        }

        private void RegisterButton_Click(object sender, RoutedEventArgs e)
        {
            var mainWindow = (MainWindow)Application.Current.MainWindow;
            mainWindow?.ChangeView(new Register());
            return;
        }

        private bool VerificateFields()
        {
            bool isNotEmpty = FieldsVerificator.VerificateEmpty(userTextBox.Text) || FieldsVerificator.VerificateEmpty(passwordTextBox.Password);
            if (!isNotEmpty)
            {
                snackbar.MessageQueue.Enqueue("Verifica no dejar campos vacíos.");
            }
            return isNotEmpty;
        }

        private void disallowSpace_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Space)
            {
                e.Handled = true;
            }
        }
    }
}
