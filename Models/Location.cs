using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace CPW221_MomsAndBabies.Models
{
    /// <summary>
    /// Represents a Location
    /// </summary>
    public class Location
    {
        /// <summary> 
        /// The unique identifier for the Location
        /// </summary>
        [Key]
        public int LocationID { get; set; }

        /// <summary>
		/// The Location's Code
		/// </summary>
        [Display(Name = "Location Code")]
        [StringLength(100)]
        [Required(ErrorMessage = "{0} is required.")]
        public string LocationCode { get; set; }

        /// <summary>
		/// The Location's Name
		/// </summary>
        [Display(Name = "Location Name")]
        [StringLength(100)]
        [Required(ErrorMessage = "{0} is required.")]
        public string LocationName { get; set; }

        /// <summary>
		/// The Location's Address
		/// </summary>
		[Display(Name = "Address")]
        [StringLength(100)]
        [Required(ErrorMessage = "{0} is required.")]
        public string Address { get; set; }

        /// <summary>
        /// The Location's City
        /// </summary>
        [Display(Name = "City")]
        [StringLength(50)]
        [Required(ErrorMessage = "{0} is required.")]
        public string City { get; set; }

        /// <summary>
        /// The Location's State
        /// </summary>
        [Display(Name = "State")]
        [Required(ErrorMessage = "{0} is required.")]
        public string State { get; set; }

        /// <summary>
        /// The Location's Zip Code
        /// </summary>
        [Display(Name = "Zip Code")]
        [DataType(DataType.PostalCode)]
        [Required(ErrorMessage = "{0} is required.")]
        public string ZipCode { get; set; }

        public List<SelectListItem> GetStateSelectList()
        {
            var states = new List<SelectListItem>
            {
                new SelectListItem { Value = "AL", Text = "Alabama" },
                new SelectListItem { Value = "AK", Text = "Alaska" },
                new SelectListItem { Value = "AZ", Text = "Arizona" },
                new SelectListItem { Value = "AR", Text = "Arkansas" },
                new SelectListItem { Value = "CA", Text = "California" },
                new SelectListItem { Value = "CO", Text = "Colorado" },
                new SelectListItem { Value = "CT", Text = "Connecticut" },
                new SelectListItem { Value = "DE", Text = "Delaware" },
                new SelectListItem { Value = "DC", Text = "District of Columbia" },
                new SelectListItem { Value = "FL", Text = "Florida" },
                new SelectListItem { Value = "GA", Text = "Georgia" },
                new SelectListItem { Value = "HI", Text = "Hawaii" },
                new SelectListItem { Value = "ID", Text = "Idaho" },
                new SelectListItem { Value = "IL", Text = "Illinois" },
                new SelectListItem { Value = "IN", Text = "Indiana" },
                new SelectListItem { Value = "IA", Text = "Iowa" },
                new SelectListItem { Value = "KS", Text = "Kansas" },
                new SelectListItem { Value = "KY", Text = "Kentucky" },
                new SelectListItem { Value = "LA", Text = "Louisiana" },
                new SelectListItem { Value = "ME", Text = "Maine" },
                new SelectListItem { Value = "MD", Text = "Maryland" },
                new SelectListItem { Value = "MA", Text = "Massachusetts" },
                new SelectListItem { Value = "MI", Text = "Michigan" },
                new SelectListItem { Value = "MN", Text = "Minnesota" },
                new SelectListItem { Value = "MS", Text = "Mississippi" },
                new SelectListItem { Value = "MO", Text = "Missouri" },
                new SelectListItem { Value = "MT", Text = "Montana" },
                new SelectListItem { Value = "NE", Text = "Nebraska" },
                new SelectListItem { Value = "NV", Text = "Nevada" },
                new SelectListItem { Value = "NH", Text = "New Hampshire" },
                new SelectListItem { Value = "NJ", Text = "New Jersey" },
                new SelectListItem { Value = "NM", Text = "New Mexico" },
                new SelectListItem { Value = "NY", Text = "New York" },
                new SelectListItem { Value = "NC", Text = "North Carolina" },
                new SelectListItem { Value = "ND", Text = "North Dakota" },
                new SelectListItem { Value = "OH", Text = "Ohio" },
                new SelectListItem { Value = "OK", Text = "Oklahoma" },
                new SelectListItem { Value = "OR", Text = "Oregon" },
                new SelectListItem { Value = "PA", Text = "Pennsylvania" },
                new SelectListItem { Value = "RI", Text = "Rhode Island" },
                new SelectListItem { Value = "SC", Text = "South Carolina" },
                new SelectListItem { Value = "SD", Text = "South Dakota" },
                new SelectListItem { Value = "TN", Text = "Tennessee" },
                new SelectListItem { Value = "TX", Text = "Texas" },
                new SelectListItem { Value = "UT", Text = "Utah" },
                new SelectListItem { Value = "VT", Text = "Vermont" },
                new SelectListItem { Value = "VA", Text = "Virginia" },
                new SelectListItem { Value = "WA", Text = "Washington" },
                new SelectListItem { Value = "WV", Text = "West Virginia" },
                new SelectListItem { Value = "WI", Text = "Wisconsin" },
                new SelectListItem { Value = "WY", Text = "Wyoming" },
            };

            return states;
        }
    }
        
}
