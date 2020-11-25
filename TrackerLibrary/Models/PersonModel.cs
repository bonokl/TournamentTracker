using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
{
    public class PersonModel
    {
        /// <summary>
        /// The unique identifier for the prize.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// First name of the person.
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Last name of the person.
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// Email address of the person.
        /// </summary>
        public string EmailAddress { get; set; }

        /// <summary>
        /// Cellphone number of the person.
        /// </summary>
        public string CellphoneNumber { get; set; }

        public string FullName { 
            get {
                return $"{FirstName} {LastName}";
            } 
        }
    }
}
