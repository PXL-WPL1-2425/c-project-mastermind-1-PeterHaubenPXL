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

namespace Mastermind
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

        private void code1ComboBox_DropDownClosed(object sender, EventArgs e)
        {
            if (code1ComboBox.Text == "Red")
            {
                code1Label.Background = Brushes.Red;
            }
            else if(code1ComboBox.Text == "Green"){
                code1Label.Background = Brushes.Green;
            }
            else if (code1ComboBox.Text == "Blue")
            {
                code1Label.Background = Brushes.Blue;
            }
            else if (code1ComboBox.Text == "Yellow")
            {
                code1Label.Background = Brushes.Yellow;
            }
            else if (code1ComboBox.Text == "Orange")
            {
                code1Label.Background = Brushes.Orange;
            }
            else if (code1ComboBox.Text == "White")
            {
                code1Label.Background = Brushes.White;
            }
            else
            {
                code1Label.Background = Brushes.Transparent;
            }
        }

        private void code2ComboBox_DropDownClosed(object sender, EventArgs e)
        {
            if (code2ComboBox.Text == "Red")
            {
                code2Label.Background = Brushes.Red;
            }
            else if (code2ComboBox.Text == "Green")
            {
                code2Label.Background = Brushes.Green;
            }
            else if (code2ComboBox.Text == "Blue")
            {
                code2Label.Background = Brushes.Blue;
            }
            else if (code2ComboBox.Text == "Yellow")
            {
                code2Label.Background = Brushes.Yellow;
            }
            else if (code2ComboBox.Text == "Orange")
            {
                code2Label.Background = Brushes.Orange;
            }
            else if (code2ComboBox.Text == "White")
            {
                code2Label.Background = Brushes.White;
            }
            else
            {
                code2Label.Background = Brushes.Transparent;
            }
        }

        private void code3ComboBox_DropDownClosed(object sender, EventArgs e)
        {
            if (code3ComboBox.Text == "Red")
            {
                code3Label.Background = Brushes.Red;
            }
            else if (code3ComboBox.Text == "Green")
            {
                code3Label.Background = Brushes.Green;
            }
            else if (code3ComboBox.Text == "Blue")
            {
                code3Label.Background = Brushes.Blue;
            }
            else if (code3ComboBox.Text == "Yellow")
            {
                code3Label.Background = Brushes.Yellow;
            }
            else if (code3ComboBox.Text == "Orange")
            {
                code3Label.Background = Brushes.Orange;
            }
            else if (code3ComboBox.Text == "White")
            {
                code3Label.Background = Brushes.White;
            }
            else
            {
                code3Label.Background = Brushes.Transparent;
            }
        }

        private void code4ComboBox_DropDownClosed(object sender, EventArgs e)
        {
            if (code4ComboBox.Text == "Red")
            {
                code4Label.Background = Brushes.Red;
            }
            else if (code4ComboBox.Text == "Green")
            {
                code4Label.Background = Brushes.Green;
            }
            else if (code4ComboBox.Text == "Blue")
            {
                code4Label.Background = Brushes.Blue;
            }
            else if (code4ComboBox.Text == "Yellow")
            {
                code4Label.Background = Brushes.Yellow;
            }
            else if (code4ComboBox.Text == "Orange")
            {
                code4Label.Background = Brushes.Orange;
            }
            else if (code4ComboBox.Text == "White")
            {
                code4Label.Background = Brushes.White;
            }
            else
            {
                code4Label.Background = Brushes.Transparent;
            }
        }

        private void controlButton_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}