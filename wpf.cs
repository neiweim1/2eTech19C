using System;
using System.Collections.Generic;
using System.IO;
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

namespace WpfApp5
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
            string nickname = name.Text;
            string plec;
            string hobby = "hobby:";
            if(gender.IsChecked ?? false) 
            {
                plec = (string)gender.Content;
            }
            else
            {
                plec = (string)gender1.Content;
            }

            if(check1.IsChecked ?? false) 
            {
                hobby += check1.Content;
            }
            if(check2.IsChecked ?? false)
            {
                hobby += check2.Content;
            }

            string me = textarea.Text;
            StreamWriter sw = File.AppendText(path: "plik.txt");
            sw.WriteLine($"imie: {nickname} \n plec{plec} \n {hobby} \n cos o sobie{me}");
            sw.Close();
            Close();

        }
    }
}
