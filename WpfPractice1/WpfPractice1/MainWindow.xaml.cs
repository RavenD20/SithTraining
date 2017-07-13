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
using static System.Console;

namespace WpfPractice1
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

        private void Action_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("How are you today");


            //TBox1.Text = "Yes!!!";
            LBLText.Content = "Gotcha";
        }
        private void TBox1_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void button2nd_Click(object sender, RoutedEventArgs e)
        {
            Window1 sec = new Window1();
            sec.ShowDialog();


            Window3 trey = new Window3();
            trey.Show();
        }


    }
}
