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
            else if (code1ComboBox.Text == "Green")
            {
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

        private void generateButton_Click(object sender, RoutedEventArgs e)
        {
            Random rnd = new Random();

            int colorCode1 = rnd.Next(0, 24);
            int colorCode2 = rnd.Next(0, 24);
            int colorCode3 = rnd.Next(0, 24);
            int colorCode4 = rnd.Next(0, 24);

            MastermindWindow.Title = "Mastermind";

            switch (colorCode1 % 6)
            {
                case 0:
                    MastermindWindow.Title += "\tRed,";
                    colorCode1 = 0;
                    break;
                case 1:
                    MastermindWindow.Title += "\tYellow,";
                    colorCode1 = 1;
                    break;
                case 2:
                    MastermindWindow.Title +=  "\tGreen,";
                    colorCode1 = 2;
                    break;
                case 3:
                    MastermindWindow.Title += "\tBlue,";
                    colorCode1 = 3;
                    break;
                case 4:
                    MastermindWindow.Title += "\tOrange,";
                    colorCode1 = 4;
                    break;
                default:
                    MastermindWindow.Title += "\tWhite,";
                    colorCode1 = 5;
                    break;
            }

            switch (colorCode2 % 6)
            {
                case 0:
                    MastermindWindow.Title += " Red,";
                    colorCode2 = 0;
                    break;
                case 1:
                    MastermindWindow.Title += " Yellow,";
                    colorCode2 = 1;
                    break;
                case 2:
                    MastermindWindow.Title += " Green,";
                    colorCode2 = 2;
                    break;
                case 3:
                    MastermindWindow.Title += " Blue,";
                    colorCode2 = 3;
                    break;
                case 4:
                    MastermindWindow.Title += " Orange,";
                    colorCode2 = 4;
                    break;
                default:
                    MastermindWindow.Title += " White,";
                    colorCode2 = 5;
                    break;
            }

            switch (colorCode3 % 6)
            {
                case 0:
                    MastermindWindow.Title += " Red,";
                    colorCode3 = 0;
                    break;
                case 1:
                    MastermindWindow.Title += " Yellow,";
                    colorCode3 = 1;
                    break;
                case 2:
                    MastermindWindow.Title += " Green,";
                    colorCode3 = 2;
                    break;
                case 3:
                    MastermindWindow.Title += " Blue,";
                    colorCode3 = 3;
                    break;
                case 4:
                    MastermindWindow.Title += " Orange,";
                    colorCode3 = 4;
                    break;
                default:
                    MastermindWindow.Title += " White,";
                    colorCode3 = 5;
                    break;
            }

            switch (colorCode4 % 6)
            {
                case 0:
                    MastermindWindow.Title += " Red";
                    colorCode4 = 0;
                    break;
                case 1:
                    MastermindWindow.Title += " Yellow";
                    colorCode4 = 1;
                    break;
                case 2:
                    MastermindWindow.Title += " Green";
                    colorCode4 = 2;
                    break;
                case 3:
                    MastermindWindow.Title += " Blue";
                    colorCode4 = 3;
                    break;
                case 4:
                    MastermindWindow.Title += " Orange";
                    colorCode4 = 4;
                    break;
                default:
                    MastermindWindow.Title += " White";
                    colorCode4 = 5;
                    break;
            }
        }

        private void controlButton_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
