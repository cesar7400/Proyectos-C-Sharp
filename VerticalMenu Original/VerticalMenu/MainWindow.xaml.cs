using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace VerticalMenu
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        static bool isMax = false, isFull = false;
        static Point old_loc, default_loc;
        static Size old_size, default_size;
        private void Button_MouseEnter(object sender, MouseEventArgs e)
        {
            if (Tg_Btn.IsChecked == false)
            {
                /*Popup.PlacementTarget = btnUsers;
                Popup.Placement = PlacementMode.Right;
                Popup.IsOpen = true;
                Header.PopupText.Text = "Dashboard";*/
            }
        }

        private void Button_MouseLeave(object sender, MouseEventArgs e)
        {
            /*Popup.Visibility = Visibility.Collapsed;
            Popup.IsOpen = false;*/
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void btnRestore_Click(object sender, RoutedEventArgs e)
        {
            Button btn = (Button)sender;
            Maximize(this, btn);
        }

        private void btnMinimize_Click(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }

        private void Tg_Btn_Click(object sender, RoutedEventArgs e)
        {
            if(Tg_Btn.IsChecked.Value)
            {
                imageLocation.Margin = new Thickness(30, -40, 0, 0);
                imageLocation.Width = 80;
                imageLocation.Height = 80;
                info.Margin = new Thickness(30, 10, 0, 10);
                txtInfo.Margin = new Thickness(30, 0, 0, 10);
            }
            else
            {
                imageLocation.Margin = new Thickness(10, - 20, 0, 30);
                imageLocation.Width = 40;
                imageLocation.Height = 40;
                info.Margin = new Thickness(10, 0, 0, 10);
                txtInfo.Margin = new Thickness(10, 0, 0, 10);
            }
        }

        private void btnDasboard_Click(object sender, RoutedEventArgs e)
        {
            fContainer.Navigate(new System.Uri("Principal.xaml", UriKind.RelativeOrAbsolute));
        }

        private void btnDasboard_MouseEnter(object sender, MouseEventArgs e)
        {
            if (Tg_Btn.IsChecked == false)
            {
                Popup.PlacementTarget = btnDasboard;
                Popup.Placement = PlacementMode.Right;
                Popup.IsOpen = true;
                Header.PopupText.Text = "Dashboard";
            }
        }

        private void btnDasboard_MouseLeave(object sender, MouseEventArgs e)
        {
            Popup.Visibility = Visibility.Collapsed;
            Popup.IsOpen = false;
        }
        
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HTCAPTION = 0x2;
        [DllImport("User32.dll")]
        public static extern bool ReleaseCapture();
        [DllImport("User32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        private void TextBlock_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ButtonState == MouseButtonState.Pressed)
            {
                ReleaseCapture();
                var winHandle = new WindowInteropHelper(this).Handle;
                SendMessage(winHandle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
            }
        }
        public static void Maximize(Window win, Button btn)
        {
            if (isMax == false) // app is currently not maximized ; then maximize it!
            {
                old_size = new Size(win.Width, win.Height);
                old_loc = new Point(win.Top, win.Left);
                Maximize(win);
                isMax = true;
                isFull = false;
                btn.Content = "2";
            }

            else // app is currentlly maximized ; then we make it normal
            {
                if (old_size.Width >= SystemParameters.WorkArea.Width ||
                    old_size.Height >= SystemParameters.WorkArea.Height)
                {
                    win.Top = default_loc.Y;
                    win.Left = default_loc.X;
                    win.Width = default_size.Width;
                    win.Height = default_size.Height;
                }

                else
                {
                    win.Top = old_loc.Y;
                    win.Left = old_loc.X;
                    win.Width = old_size.Width;
                    win.Height = old_size.Height;
                }
                isMax = false;
                isFull = false;
                btn.Content = "1";
            }
        }
        static void Maximize(Window win)
        {
            double x = SystemParameters.WorkArea.Width;
            double y = SystemParameters.WorkArea.Height;
            win.Top = 0;
            win.Left = 0;
            win.Width = x;
            win.Height = y;
        }
    }
}
