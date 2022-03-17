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

namespace Books2
{
    public enum Theme
    {
        English, Russian, History, Chemisty
    }
    public partial class MainWindow : Window
    {
        Themes facultet = new Themes();
        public MainWindow()
        {
            InitializeComponent();

        }

        private void History_Checked(object sender, RoutedEventArgs e)
        {
            Catalog.Text = "Format: Name_Student,Sudent_number,Facultet." + '\n';
            for (int i = 0; i < 10; i++)
            {
                if (facultet.Theme_str[i] == Convert.ToString(Theme.History))
                    Catalog.Text += facultet.Name_Students[i] + ", " + Convert.ToString(i + 1) + ", " + facultet.Theme_str[i] + "." + '\n';
            }
        }

        private void Ok_Click(object sender, RoutedEventArgs e)
        {
            Catalog.Text = "Format: Name_Student,Sudent_number,Facultet." + '\n';
            for (int i = 0; i < 10; i++)
            {
                Catalog.Text += facultet.Name_Students[i] + ", " + Convert.ToString(i + 1) + ", " + facultet.Theme_str[i] + "." + '\n';
            }
        }

        private void Russian_Checked(object sender, RoutedEventArgs e)
        {
            Catalog.Text = "Format: Name_Student,Sudent_number,Facultet." + '\n';
            for (int i = 0; i < 10; i++)
            {
                if (facultet.Theme_str[i] == Convert.ToString(Theme.Russian))
                    Catalog.Text += facultet.Name_Students[i] + ", " + Convert.ToString(i + 1) + ", " + facultet.Theme_str[i] + "." + '\n';
            }
        }

        private void Chemisty_Checked(object sender, RoutedEventArgs e)
        {
            Catalog.Text = "Format: Name_Student,Sudent_number,Facultet." + '\n';
            for (int i = 0; i < 10; i++)
            {
                if (facultet.Theme_str[i] == Convert.ToString(Theme.Chemisty))
                    Catalog.Text += facultet.Name_Students[i] + ", " + Convert.ToString(i + 1) + ", " + facultet.Theme_str[i] + "." + '\n';
            }
        }

        private void English_Checked(object sender, RoutedEventArgs e)
        {
            Catalog.Text = "Format: Name_Student,Sudent_number,Facultet." + '\n';
            for (int i = 0; i < 10; i++)
            {
                if (facultet.Theme_str[i] == Convert.ToString(Theme.English))
                    Catalog.Text += facultet.Name_Students[i] + ", " + Convert.ToString(i + 1) + ", " + facultet.Theme_str[i] + "." + '\n';
            }
        }
    }
}
