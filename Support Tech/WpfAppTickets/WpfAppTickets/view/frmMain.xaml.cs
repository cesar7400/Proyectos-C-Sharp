using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
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

namespace WpfAppTickets.view
{
    /// <summary>
    /// Lógica de interacción para frmMain.xaml
    /// </summary>
    public partial class frmMain : Window
    {
        public frmMain()
        {
            InitializeComponent();
        }
        private static string _id;
        public string Id
        {
            get {return _id;}
            set { _id = value;}
        }
        private void btnMenu_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (gridSlide.Width.Value == 80)
            {
                gridSlide.Width = new GridLength(170, GridUnitType.Pixel);
                btnMenu.Margin = new Thickness(0, 10, 90, 0);
                txtUsers.Text = "Usuarios";
                txtPersonal.Text = "Personal";
                txtTicket.Text = "Ticket";
                txtSeguimiento.Text = "Seguimiento";
                txtSalir.Text = "Cerrar sesión";
            }
            else
            {
                gridSlide.Width = new GridLength(80, GridUnitType.Pixel);
                btnMenu.Margin = new Thickness(0, 10, 0, 0);
                txtUsers.Text = string.Empty;
                txtPersonal.Text = string.Empty;
                txtTicket.Text = string.Empty;
                txtSeguimiento.Text = string.Empty;
                txtSalir.Text = string.Empty;
            }
        }
        
        private void imgUsuarios_MouseDown(object sender, MouseButtonEventArgs e)
        {
            navframe.NavigationService.Navigate(new Uri("view/frmUsuarios.xaml", UriKind.Relative));
        }

        private void imgPersonal_MouseDown(object sender, MouseButtonEventArgs e)
        {
            navframe.NavigationService.Navigate(new Uri("view/frmPersonal.xaml", UriKind.Relative));
        }

        private void imgTicket_MouseDown(object sender, MouseButtonEventArgs e)
        {
            navframe.NavigationService.Navigate(new Uri("view/frmTicket.xaml", UriKind.Relative));
        }

        private void imgSeguimiento_MouseDown(object sender, MouseButtonEventArgs e)
        {
            navframe.NavigationService.Navigate(new Uri("view/frmSeguimiento.xaml", UriKind.Relative));
        }
        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            //Environment.Exit(0);
        }
        private void imgSalir_MouseDown(object sender, MouseButtonEventArgs e)
        {
            frmLogin frmLogin = new frmLogin();
            frmLogin.Show();
            this.Close();
        }
    }
}
