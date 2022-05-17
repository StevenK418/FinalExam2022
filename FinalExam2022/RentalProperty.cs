using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalExam2022
{
    class RentalProperty
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


    }
}
