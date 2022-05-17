using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
