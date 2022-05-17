using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace FinalExam2022
{
    public class RentalProperty
    {
        public int RentalPropertyID { get; set; }

        public enum RentalType 
        {
            House,
            Flat,
            Share
        }

        public RentalType rentalType { get; set; }

        public string Location { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }


        /// <summary>
        /// Adjusts thee rent amount by a given percentage
        /// </summary>
        /// <param name="percent"></param>
        /// <returns></returns>
        public decimal IncreaseRentByPercentageAmount(decimal percent)
        {
            //declare new variable to store the new amount
            decimal AdjusteRentAmount = 0;

            //Calculate the new price and store
            AdjusteRentAmount = Price * percent;

            //Return the result
            return AdjusteRentAmount;
        }

        //Default Constructor
        public RentalProperty() { }

        //Parametrised Constructor
        public RentalProperty(decimal Price, RentalProperty.RentalType TypeOfRental, string Description, string Location)
        {
            this.Price = Price;
            this.rentalType = TypeOfRental;
            this.Description = Description;
            this.Location = Location;
        }

        /// <summary>
        /// Overrides the ToString method of the parent Object class.
        /// </summary>
        /// <returns>Returns a formatted string of the movie Title and Year.</returns>
        public override string ToString()
        {
            return string.Format($"{Location} - {Price}");
        }

        public class RentalPropertyData : DbContext
        {
            public RentalPropertyData() : base("RentalPropertyData")
            {
            }

            public DbSet<RentalProperty> RentalProperties { get; set; }
        }
    }
}
