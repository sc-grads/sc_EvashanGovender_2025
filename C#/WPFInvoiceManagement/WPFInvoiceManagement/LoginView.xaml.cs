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

namespace WPFInvoiceManagement
{
    /// <summary>
    /// Interaction logic for LoginView.xaml
    /// </summary>
    public partial class LoginView : UserControl
    {
        public LoginView()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var password = PasswordBox.Password;
            string? envpassword = Environment.GetEnvironmentVariable("InvoiceManagement");
            if (envpassword != null)
            {
                if(password == envpassword)
                {
                    MessageBox.Show("Login successful!");
                }
                else
                {
                    MessageBox.Show("Login failed! Please check your password.");
                }
            }
            else
            {
                MessageBox.Show("Environment variable 'InvoiceManagement' is not set.");
            }
    }
}
