using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WPFDataBinding.Data;

namespace WPFDataBinding
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Person person = new Person
        {
            Age = 30,
            Name = "Jannick"
        };
        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = person;// Set the DataContext to the person object
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string personInfo = $"Name: {person.Name}, Age: {person.Age}";
            MessageBox.Show(personInfo, "Person Information", MessageBoxButton.OK, MessageBoxImage.Information);
            // Example of data binding in action
            //var textBox = new TextBox();
            //textBox.Text = "Hello, World!";
            //MyStackPanel.Children.Add(textBox);
        }
    }
}