/*
 *  Name:       Steven Kelly
 *  ID:         S00200293
 *  GithubL     https://github.com/StevenK418/FinalExam2022.git
 *  Dev Notes: Most changes are on the develop branch of the repo. 
 *
 */

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

namespace FinalExam2022
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

        private void BTN_Add_Click(object sender, RoutedEventArgs e)
        {
            //Create  anew instance of the Add Property window class
            AddProperty addPropertyWindow = new AddProperty();

            //Display the add property window. 
            addPropertyWindow.Show();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //Create  new dbmanager instance
            DatabaseManager dbManager = new DatabaseManager();

            //Populate the db with initial data
            DatabaseManager.InitializeDatabaseWithData();

            //Get all the properties in the db and set as listbox datasource. 
            LSTBX_Properties.ItemsSource = dbManager.GetAllPropertiesFromDB();
        }
    }
}
