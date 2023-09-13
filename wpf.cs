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
    /*
        <Window x:Class="WpfApp5.MainWindow"
        xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
        xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
        xmlns:d="http://schemas.microsoft.com/expression/blend/2008"
        xmlns:mc="http://schemas.openxmlformats.org/markup-compatibility/2006"
        xmlns:local="clr-namespace:WpfApp5"
        mc:Ignorable="d"
        Title="MainWindow" Height="450" Width="800">
    <Grid>
        <Grid.RowDefinitions>
            <RowDefinition Height="2*"/>
            <RowDefinition Height="29*"/>
        </Grid.RowDefinitions>
        <TextBox  TextWrapping="Wrap" Margin="359,28,374,385" Grid.RowSpan="2" Background="#FFFFBD6D" x:Name="name"/>
        <CheckBox Content="kotki &lt;3" Margin="364,125,331,261" Grid.Row="1" x:Name="check1"/>
        <CheckBox Content="gry" Margin="364,150,342,231"  Grid.Row="1"  x:Name="check2"/>
        <RadioButton Content="woman haha" Margin="374,52,335,338" Grid.Row="1" x:Name="gender" IsChecked="False"/>
        <RadioButton Content="men" Margin="374,73,374,317" Grid.Row="1" x:Name="gender1"/>
        <TextBox Name="textarea"
            TextWrapping="Wrap"
            AcceptsReturn="True"
             VerticalScrollBarVisibility="Visible" Margin="203,213,223,20" Background="#FFFFAEAE"  Grid.Row="1">

        </TextBox>
        <Label Content="plec" Margin="263,47,438,333" Grid.Row="1" Background="#FFFFBEBE"/>
        <Label Content="hobby" Margin="263,96,438,284" Grid.Row="1" Background="#FFFFBEBE"/>
        <Button Content="Button" Margin="71,358,661,20" Grid.Row="1" Click="Button_Click"/>
    </Grid>
</Window>

    */
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
