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

namespace WpfApp2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int buf_clear = 0;
        int buf_paste = 0;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void CopyContents_Click(object sender, RoutedEventArgs e)
        {
            textBox1.Copy();
        }

        private void SelectionChange_comboBox2(object sender, SelectionChangedEventArgs e)
        {
            textBox1.Clear();
            if (comboBox2.SelectedIndex == 0)
            {
                textBox1.MaxLength = 5;
            }
            else if (comboBox2.SelectedIndex == 1)
            {
                textBox1.MaxLength = 6;
            }
            else if (comboBox2.SelectedIndex == 2)
            {
                textBox1.MaxLength = 7;
            }
            else if (comboBox2.SelectedIndex == 3)
            {
                textBox1.MaxLength = 8;
            }
            else
            {
                textBox1.MaxLength = 10;
            }
            textBlock_1.Text = textBox1.MaxLength.ToString();
            textBox1.IsEnabled = true;
        }

        private void SelectionChange_comboBox1(object sender, SelectionChangedEventArgs e)
        {
            passwordBox.Clear();
            if (comboBox1.SelectedIndex == 0)
            {
                passwordBox.PasswordChar = (Char)42;
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                passwordBox.PasswordChar = (Char)43;
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                passwordBox.PasswordChar = (Char)176;
            }
            else
            {
                passwordBox.PasswordChar = (Char)174;
            }
            passwordBox.IsEnabled = true;
        }

        private void Button_Clear_Click(object sender, RoutedEventArgs e)
        {
            buf_clear++;
            buf_clear = Convert.ToInt16(textBlock1.Text);
            textBlock1.Text = buf_clear.ToString();
            passwordBox.Clear();
        }

        private void Button_Paste_Click(object sender, RoutedEventArgs e)
        {
            buf_paste = Convert.ToInt16(textBlock1.Text);
            buf_paste++;
            textBlock1.Text = buf_paste.ToString();
            passwordBox.Password = textBox1.SelectedText;
        }
    }
}
