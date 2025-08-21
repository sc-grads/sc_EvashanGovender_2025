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

namespace WPFToDoApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string todoText = ToDoInput.Text.Trim();
            if (!string.IsNullOrEmpty(todoText))
            {
                // Create a new TextBlock for the ToDo item
                TextBlock todoItem = new TextBlock
                {
                    Text = todoText,
                    Margin = new Thickness(10),
                    Foreground = new SolidColorBrush(Colors.White),
                };

                // Add the new ToDo item to the StackPanel
                ToDoList.Children.Add(todoItem);
                // Clear the input field
                ToDoInput.Clear();
            }
            else
            {
                MessageBox.Show("Please enter a valid ToDo item.", "Input Error", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }
    }
}