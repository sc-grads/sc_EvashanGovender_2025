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

namespace StudentRegistrationProject
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ConnectToDB dbc = new ConnectToDB();
        public MainWindow()
        {
            InitializeComponent();
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            dbc.Registerstudent(int.Parse(txtID.Text), txtName.Text, txtSurname.Text, txtAddress.Text, txtCity.Text, txtCellphone.Text);
            MessageBox.Show("Student Registered Successfully");
            txtID.Clear();
            txtName.Clear();
            txtSurname.Clear();
            txtAddress.Clear();
            txtCity.Clear();
            txtCellphone.Clear();

        }

        private void Delete(object sender, RoutedEventArgs e)
        {
           
            dbc.Deletestudent(int.Parse(txtID.Text));
            MessageBox.Show("Student Deleted Successfully");
            txtID.Clear();  
            txtName.Clear();
            txtSurname.Clear();
            txtAddress.Clear();
            txtCity.Clear();
            txtCellphone.Clear();
        }

        private void Update(object sender, RoutedEventArgs e)
        {
            dbc.Updatestudent(int.Parse(txtID.Text), txtName.Text, txtSurname.Text, txtAddress.Text, txtCity.Text, txtCellphone.Text);
            MessageBox.Show("Student Updated Successfully");
            txtID.Clear();
            txtName.Clear();
            txtSurname.Clear();
            txtAddress.Clear();
            txtCity.Clear();
            txtCellphone.Clear();
        }

        private void Read(object sender, RoutedEventArgs e)
        {
            StudentData sd = new StudentData();
            sd.Show();
        }
    }
}
