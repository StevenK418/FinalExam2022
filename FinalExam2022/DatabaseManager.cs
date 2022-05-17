using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalExam2022
{
    class DatabaseManager
    {
        //Create a new instance of the rental property db class
        public static RentalProperty.RentalPropertyData db = new RentalProperty.RentalPropertyData();

        /// <summary>
        /// Adds a new List of properties to the database
        /// </summary>
        /// <param name="Properties"></param>
        public static void AddToDatabase(List<RentalProperty> properties)
        {
            using (db = new RentalProperty.RentalPropertyData())
            { 
                //Create the propeties in the table
                foreach (RentalProperty property in properties)
                {
                    //Add each property to the database
                    db.RentalProperties.Add(property);
                }

                //Save the changes to the database
                db.SaveChanges();
            }
        }
        
        public static void InitializeDatabaseWithData()
        {
            //Instantiate new Rental Property objects
            RentalProperty rp1 = new RentalProperty
                (
                    400,
                    RentalProperty.RentalType.Flat,
                    "A modern 1 bedroom apartment located close to the campus." +
                    "  The accomodation comprises of 1 en-suite bedroom with a study area, " +
                    "a small kitchen and a lounge/dining room",
                    "Town Centre"
                 )
            { };


            RentalProperty rp2 = new RentalProperty
               (
                   400,
                   RentalProperty.RentalType.House,
                    "A modern 4 bedroom townhouse located 2 km from the campus. " +
                    "The house has 4 large double bedrooms with ample space for a desk, " +
                    "a large kitchen with all mod cons.  " +
                    "There is also a dining room and a large sitting room",
                    "Ballinode"
                )
            { };


            RentalProperty rp3 = new RentalProperty
               (
                   400,
                   RentalProperty.RentalType.House,
                   "1 bedroom available to share in a 3 bedroom house located in the " +
                    "beautiful seaside village of Strandhill.  The property is located on the bus route to " +
                    "IT Sligo with regular buses to and from the campus",
                    "Strandhill"
                )
            { };

            //Create a new ist to store the properties
            List<RentalProperty> rentalProperties = new List<RentalProperty>();

            //Add the new properties to the list
            rentalProperties.Add(rp1);
            rentalProperties.Add(rp2);
            rentalProperties.Add(rp3);

            //Pass the new popeties to the add to database method. 
            AddToDatabase(rentalProperties);
        }


        /// <summary>
        /// Gets a list of properties from the db
        /// </summary>
        /// <returns></returns>
        public List<RentalProperty> GetAllPropertiesFromDB()
        {
            //Use new dbcontext to avoid disposal error. 
            using (db = new RentalProperty.RentalPropertyData())
            {
                //Query the database for all properties
                var query = from p in db.RentalProperties
                            select p;

                //Convert the results to a list and return
                return query.ToList();
            }
        }
    }
}
