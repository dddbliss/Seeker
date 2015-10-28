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

namespace Seeker.Views
{
    /// <summary>
    /// Interaction logic for SettingsView.xaml
    /// </summary>
    public partial class SettingsView
    { 
        public SettingsView()
        {
            InitializeComponent();
        }

        private void txtPassword_PasswordChanged(object sender, RoutedEventArgs e)
        {
            if (this.DataContext != null)
            { ((dynamic)this.DataContext).Password = ((PasswordBox)sender).Password; }
        }

        private void MetroWindow_Loaded(object sender, RoutedEventArgs e)
        {
            if (this.DataContext != null)
            {
                txtPassword.Password = Properties.Settings.Default.Login_Password;
                txtProxyPassword.Password = Properties.Settings.Default.Web_ProxyPassword;
            }
        }

        private void txtProxyPassword_PasswordChanged(object sender, RoutedEventArgs e)
        {
            if (this.DataContext != null)
            { ((dynamic)this.DataContext).ProxyPassword = ((PasswordBox)sender).Password; }
        }
    }
}
