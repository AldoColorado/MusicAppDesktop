using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using FEiMusic.Api;
using FEiMusic.Model;
using FEiMusic.Client;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Newtonsoft.Json;
using FEiMusic.Utilities;
using MaterialDesignThemes.Wpf;

namespace FEiMusic.View
{
    /// <summary>
    /// Lógica de interacción para Register.xaml
    /// </summary>
    public partial class Register : Page
    {
        public Register()
        {
            InitializeComponent();
        }

        private void backButton_Click(object sender, RoutedEventArgs e)
        {
            if (NavigationService.CanGoBack)
                NavigationService.GoBack();
        }

        private void registerButton_Click(object sender, RoutedEventArgs e)
        {
            if (VerificateFields())
            {
                try
                {
                    DefaultApi defaultApi = new DefaultApi();
                    Cuenta cuenta = new Cuenta(userTextBox.Text, emailTextBox.Text, passwordTextBox.Password, "Consumidor");

                    var responseCuenta = defaultApi.CuentaPost(cuenta);

                    if (responseCuenta.Username.Length > 0)
                    {
                        Consumidor consumidor = new Consumidor(nombre: nameTextBox.Text, apellidos: lastNameTextBox.Text, username: responseCuenta.Username);
                        var responseConsumidor = defaultApi.ConsumidorPost(consumidor);
                        if (responseConsumidor.Username.Length > 0)
                        {
                            changeComponentsAllowability();
                            snackbar.MessageQueue.Enqueue("La cuenta se creo con exito.", "ACEPTAR", () => backButton_Click(new object(), new RoutedEventArgs()));
                        }
                    }
                }
                catch (ApiException ex)
                {
                    if (ex.ErrorCode == 400)
                        snackbar.MessageQueue.Enqueue("No se pudo crear la cuenta.");
                }
                
            }
        }

        private void changeComponentsAllowability()
        {
            nameTextBox.IsEnabled = false;
            lastNameTextBox.IsEnabled = false;
            emailTextBox.IsEnabled = false;
            userTextBox.IsEnabled = false;
            passwordTextBox.IsEnabled = false;
            registerButton.IsEnabled = false;
        }

        private bool VerificateFields()
        {
            bool isValid = FieldsVerificator.VerificateEmpty(passwordTextBox.Password);
            if (!isValid)
            {
                snackbar.MessageQueue.Enqueue("Verifica no dejar campos vacíos.");
                return isValid;
            }
                
            isValid = FieldsVerificator.VerificateName(nameTextBox.Text) && FieldsVerificator.VerificateName(lastNameTextBox.Text);
            if (!isValid)
            {
                snackbar.MessageQueue.Enqueue("Verifique que el nombre y apellidos tenga datos alfabéticos.");
                return isValid;
            }

            isValid = FieldsVerificator.VerificateEmail(emailTextBox.Text);
            if (!isValid)
            {
                snackbar.MessageQueue.Enqueue("Verifique el formato del correo electrónico.");
                return isValid;
            }
                
            return isValid;
        }
    }
}

/*private void PostItem()
        {
            var client = new RestClient("http://localhost:4000/feimusic");
            var request = new RestRequest("/Cuenta", Method.POST);
            request.AddParameter("username", userTextBox.Text);
            request.AddParameter("correo", emailTextBox.Text);
            request.AddParameter("password", passwordTextBox.Password);
            var response = client.Execute(request);



            if (response.IsSuccessful)
            {
                snackbar.MessageQueue.Enqueue(response.Content);
            }
        }*/
