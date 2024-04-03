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

namespace drogy
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
        MessageBox.Show("Tlačítko bylo stisknuto!");
    }

    private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
    {
        TextBox textBox = sender as TextBox;
        if (textBox != null)
        {
            MessageBox.Show($"Text v TextBoxu byl změněn na: {textBox.Text}");
        }
    }

        private void Button_MouseEnter(object sender, MouseEventArgs e)
        {
            MessageBox.Show("Myš vstoupila na tlačítko!");
        }
    }
}
