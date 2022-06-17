using System;
using System.Collections.Generic;
using System.Linq;
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

namespace Practika1_EX2
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

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            string otv = textBox1.Text;

            otv = otv.Replace(",", " y:");
            otv = "x:" + otv;

            textBlock1.Text = otv;
        }

        private void textBlock1_Loaded(object sender, RoutedEventArgs e)
        {
            string otv;
            while ((otv = Console.ReadLine()) != null)
            {
                otv = otv.Replace(",", " y:");
                otv = "x:" + otv;
                textBlock1.Text += otv;
            }
        }
    }
}
