using System;
using System.Windows;
using System.Windows.Input;
using WpfAppTickets.controller;

namespace WpfAppTickets.view
{
    /// <summary>
    /// Lógica de interacción para frmLogin.xaml
    /// </summary>
    public partial class frmLogin : Window
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        private void imgClose_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                Environment.Exit(0);
            }
        }
        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            if(txtUser.Text == string.Empty) 
            {
                MessageBox.Show("Nombre de usuario esta vacío", "Usuario", MessageBoxButton.OK, MessageBoxImage.Information);
                return;
            }
            else if (txtPassword.Password == string.Empty)
            {
                MessageBox.Show("Contraseña esta vacío", "Contraseña", MessageBoxButton.OK, MessageBoxImage.Information);
                return;
            }
            else
            {
                ClsUsuarioController clsUsuarioController = new ClsUsuarioController();
                var login = clsUsuarioController.loginUsuario(txtUser.Text.Trim(), txtPassword.Password);
                if (login.Count != 0)
                {
                    if (login[1] == "1")
                    {
                        frmMain frmMain = new frmMain();
                        frmMain.Id = login[0];
                        frmMain.Show();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("No puedes iniciar sesión, se encuentra desactivado", "Mensaje", MessageBoxButton.OK, MessageBoxImage.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Usuario y/o contraseña no validos", "Error inicio de sesión", MessageBoxButton.OK, MessageBoxImage.Error);
                    txtPassword.Focus();
                }
            }
        }
        /*
         login: admin
         contraseña: 123456
         */
    }
}