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
        //Globale variable

        int colorCode1 = 0;
        int colorCode2 = 0;
        int colorCode3 = 0;
        int colorCode4 = 0;

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

            code1Label.BorderBrush = code1Label.Background;
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

            code2Label.BorderBrush = code2Label.Background;
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

            code3Label.BorderBrush = code3Label.Background;
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

            code4Label.BorderBrush = code4Label.Background;
        }

        private void generateButton_Click(object sender, RoutedEventArgs e)
        {
            Random rnd = new Random();

            colorCode1 = rnd.Next(0, 24);
            colorCode2 = rnd.Next(0, 24);
            colorCode3 = rnd.Next(0, 24);
            colorCode4 = rnd.Next(0, 24);

            code1ComboBox.SelectedIndex = 0;
            code2ComboBox.SelectedIndex = 0;
            code3ComboBox.SelectedIndex = 0;
            code4ComboBox.SelectedIndex = 0;

            code1Label.Background = Brushes.Transparent;
            code2Label.Background = Brushes.Transparent;
            code3Label.Background = Brushes.Transparent;
            code4Label.Background = Brushes.Transparent;

            code1Label.BorderBrush = Brushes.Transparent;
            code2Label.BorderBrush = Brushes.Transparent;
            code3Label.BorderBrush = Brushes.Transparent;
            code4Label.BorderBrush = Brushes.Transparent;

            MastermindWindow.Title = "Mastermind";

            switch (colorCode1 % 6)
            {
                case 0:
                    MastermindWindow.Title += "\tRed,";
                    colorCode1 = 1;
                    break;
                case 1:
                    MastermindWindow.Title += "\tYellow,";
                    colorCode1 = 2;
                    break;
                case 2:
                    MastermindWindow.Title += "\tOrange,";
                    colorCode1 = 3;
                    break;
                case 3:
                    MastermindWindow.Title += "\tWhite,";
                    colorCode1 = 4;
                    break;
                case 4:
                    MastermindWindow.Title += "\tGreen,";
                    colorCode1 = 5;
                    break;
                default:
                    MastermindWindow.Title += "\tBlue,";
                    colorCode1 = 6;
                    break;
            }

            switch (colorCode2 % 6)
            {
                case 0:
                    MastermindWindow.Title += " Red,";
                    colorCode2 = 1;
                    break;
                case 1:
                    MastermindWindow.Title += " Yellow,";
                    colorCode2 = 2;
                    break;
                case 2:
                    MastermindWindow.Title += " Orange,";
                    colorCode2 = 3;
                    break;
                case 3:
                    MastermindWindow.Title += " White,";
                    colorCode2 = 4;
                    break;
                case 4:
                    MastermindWindow.Title += " Green,";
                    colorCode2 = 5;
                    break;
                default:
                    MastermindWindow.Title += " Blue,";
                    colorCode2 = 6;
                    break;
            }

            switch (colorCode3 % 6)
            {
                case 0:
                    MastermindWindow.Title += " Red,";
                    colorCode3 = 1;
                    break;
                case 1:
                    MastermindWindow.Title += " Yellow,";
                    colorCode3 = 2;
                    break;
                case 2:
                    MastermindWindow.Title += " Orange,";
                    colorCode3 = 3;
                    break;
                case 3:
                    MastermindWindow.Title += " White,";
                    colorCode3 = 4;
                    break;
                case 4:
                    MastermindWindow.Title += " Green,";
                    colorCode3 = 5;
                    break;
                default:
                    MastermindWindow.Title += " Blue,";
                    colorCode3 = 6;
                    break;
            }

            switch (colorCode4 % 6)
            {
                case 0:
                    MastermindWindow.Title += " Red";
                    colorCode4 = 1;
                    break;
                case 1:
                    MastermindWindow.Title += " Yello,";
                    colorCode4 = 2;
                    break;
                case 2:
                    MastermindWindow.Title += " Orange";
                    colorCode4 = 3;
                    break;
                case 3:
                    MastermindWindow.Title += " White";
                    colorCode4 = 4;
                    break;
                case 4:
                    MastermindWindow.Title += " Green";
                    colorCode4 = 5;
                    break;
                default:
                    MastermindWindow.Title += " Blue";
                    colorCode4 = 6;
                    break;
            }

            controlButton.IsEnabled = true;
        }

        private void controlButton_Click(object sender, RoutedEventArgs e)
        {
            // Resetten waardes

            bool gezien1 = false;
            bool gezien2 = false;
            bool gezien3 = false;
            bool gezien4 = false;

            bool positie1 = false;
            bool positie2 = false;
            bool positie3 = false;
            bool positie4 = false;

            // resetten randen

            code1Label.BorderBrush = code1Label.Background;
            code2Label.BorderBrush = code2Label.Background;
            code3Label.BorderBrush = code3Label.Background;
            code4Label.BorderBrush = code4Label.Background;

            if (code1ComboBox.SelectedIndex > 0 &&
                code2ComboBox.SelectedIndex > 0 &&
                code3ComboBox.SelectedIndex > 0 &&
                code4ComboBox.SelectedIndex > 0)
            {
                //Controleren juiste kleur op juiste plaats

                if (colorCode1 == code1ComboBox.SelectedIndex)
                {
                    code1Label.BorderBrush = Brushes.DarkRed;
                    gezien1 = true;
                    positie1 = true;
                }

                if (colorCode2 == code2ComboBox.SelectedIndex)
                {
                    code2Label.BorderBrush = Brushes.DarkRed;
                    gezien2 = true;
                    positie2 = true;
                }

                if (colorCode3 == code3ComboBox.SelectedIndex)
                {
                    code3Label.BorderBrush = Brushes.DarkRed;
                    gezien3 = true;
                    positie3 = true;
                }

                if (colorCode4 == code4ComboBox.SelectedIndex)
                {
                    code4Label.BorderBrush = Brushes.DarkRed;
                    gezien4 = true;
                    positie4 = true;
                }

                // Checken of de kleur ergens anders voorkomt

                if (gezien1 == false)
                {
                    if (code1ComboBox.SelectedIndex == colorCode2 && positie2 == false)
                    {
                        code1Label.BorderBrush = Brushes.Wheat;
                        positie2 = true;
                    }
                    else if (code1ComboBox.SelectedIndex == colorCode3 && positie3 == false)
                    {
                        code1Label.BorderBrush = Brushes.Wheat;
                        positie3 = true;
                    }
                    else if (code1ComboBox.SelectedIndex == colorCode4 && positie4 == false)
                    {
                        code1Label.BorderBrush = Brushes.Wheat;
                        positie4 = true;
                    }
                }

                if (gezien2 == false)
                {
                    if (code2ComboBox.SelectedIndex == colorCode1 && positie1 == false)
                    {
                        code2Label.BorderBrush = Brushes.Wheat;
                        positie1 = true;
                    }
                    else if (code2ComboBox.SelectedIndex == colorCode3 && positie3 == false)
                    {
                        code2Label.BorderBrush = Brushes.Wheat;
                        positie3 = true;
                    }
                    else if (code2ComboBox.SelectedIndex == colorCode4 && positie4 == false)
                    {
                        code2Label.BorderBrush = Brushes.Wheat;
                        positie4 = true;
                    }
                }

                if (gezien3 == false)
                {
                    if (code3ComboBox.SelectedIndex == colorCode1 && positie1 == false)
                    {
                        code3Label.BorderBrush = Brushes.Wheat;
                        positie1 = true;
                    }
                    else if (code3ComboBox.SelectedIndex == colorCode2 && positie2 == false)
                    {
                        code3Label.BorderBrush = Brushes.Wheat;
                        positie2 = true;
                    }
                    else if (code3ComboBox.SelectedIndex == colorCode4 && positie4 == false)
                    {
                        code3Label.BorderBrush = Brushes.Wheat;
                        positie4 = true;
                    }
                }

                if (gezien4 == false)
                {
                    if (code4ComboBox.SelectedIndex == colorCode1 && positie1 == false)
                    {
                        code4Label.BorderBrush = Brushes.Wheat;
                        positie1 = true;
                    }
                    else if (code4ComboBox.SelectedIndex == colorCode2 && positie2 == false)
                    {
                        code4Label.BorderBrush = Brushes.Wheat;
                        positie2 = true;
                    }
                    else if (code4ComboBox.SelectedIndex == colorCode3 && positie3 == false)
                    {
                        code4Label.BorderBrush = Brushes.Wheat;
                        positie3 = true;
                    }
                }
            }
            else
            {
                MessageBox.Show("Maak een keuze voor alle vakken", "Keuze");
            }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            code1ComboBox.Items.Add("");
            code2ComboBox.Items.Add("");
            code3ComboBox.Items.Add("");
            code4ComboBox.Items.Add("");

            for (int i = 1; i < 7; i++)
            {
                if (i == 1)
                {
                    code1ComboBox.Items.Add("Red");
                    code2ComboBox.Items.Add("Red");
                    code3ComboBox.Items.Add("Red");
                    code4ComboBox.Items.Add("Red");
                }

                if (i == 2)
                {
                    code1ComboBox.Items.Add("Yellow");
                    code2ComboBox.Items.Add("Yellow");
                    code3ComboBox.Items.Add("Yellow");
                    code4ComboBox.Items.Add("Yellow");
                }


                if (i == 3)
                {
                    code1ComboBox.Items.Add("Orange");
                    code2ComboBox.Items.Add("Orange");
                    code3ComboBox.Items.Add("Orange");
                    code4ComboBox.Items.Add("Orange");
                }

                if (i == 4)
                {
                    code1ComboBox.Items.Add("White");
                    code2ComboBox.Items.Add("White");
                    code3ComboBox.Items.Add("White");
                    code4ComboBox.Items.Add("White");
                }

                if (i == 5)
                {
                    code1ComboBox.Items.Add("Green");
                    code2ComboBox.Items.Add("Green");
                    code3ComboBox.Items.Add("Green");
                    code4ComboBox.Items.Add("Green");
                }

                if (i == 6)
                {
                    code1ComboBox.Items.Add("Blue");
                    code2ComboBox.Items.Add("Blue");
                    code3ComboBox.Items.Add("Blue");
                    code4ComboBox.Items.Add("Blue");
                }
            }
        }
    }
}
