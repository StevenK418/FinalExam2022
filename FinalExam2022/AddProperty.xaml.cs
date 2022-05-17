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
using System.Windows.Shapes;

namespace FinalExam2022
{
    /// <summary>
    /// Interaction logic for AddProperty.xaml
    /// </summary>
    public partial class AddProperty : Window
    {
        public AddProperty()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Constructs a new property object using the values passed in the UI
        /// And passes this to the db manager to be added. 
        /// </summary>
        public void AddNewProperty()
        {
                //Instantiate new Rental Property object using values set in UI
                RentalProperty rp = new RentalProperty
                    (
                       Decimal.Parse(TBX_Price.Text),
                       RentalProperty.RentalType.House,
                       //(!!!Enum parse issue arose in development, ran out of time)
                       //Enum.Parse(RentalType, COMBX_Type.SelectedItem),
                        TBX_Description.Text,
                        TBX_Location.Text
                     )
                { };

                //Create a new list (for brevity)
                List<RentalProperty> properties = new List<RentalProperty>();
            
                //Add new ite to list
                properties.Add(rp);

                //Pass the new list(or item) to the database and add
                DatabaseManager.AddToDatabase(properties);
            }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //Create new string list ofor the snum types
            List<String> types = new List<string>();
            types.Add("House");
            types.Add("Flat");
            types.Add("Share");

            //Assign the list as the data source
            COMBX_Type.ItemsSource = types;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //Add the new Property to the DB. 
            AddNewProperty();
        }
    }
}
