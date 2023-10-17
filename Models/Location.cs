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

        // State Abbreviations or Full State Names?
        // Dropdown list for State?
        // Use enum for State?
    }

    public enum State
    {
        [Display(Name = "Alabama")]
        AL,
        [Display(Name = "Alaska")]
        AK,
        [Display(Name = "Arkansas")]
        AR,
        [Display(Name = "Arizona")]
        AZ,
        [Display(Name = "California")]
        CA,
        [Display(Name = "Colorado")]
        CO,
        [Display(Name = "Connecticut")]
        CT,
        [Display(Name = "District of Columbia")]
        DC,
        [Display(Name = "Delaware")]
        DE,
        [Display(Name = "Florida")]
        FL,
        [Display(Name = "Georgia")]
        GA,
        [Display(Name = "Hawaii")]
        HI,
        [Display(Name = "Iowa")]
        IA,
        [Display(Name = "Idaho")]
        ID,
        [Display(Name = "Illinois")]
        IL,
        [Display(Name = "Indiana")]
        IN,
        [Display(Name = "Kansas")]
        KS,
        [Display(Name = "Kentucky")]
        KY,
        [Display(Name = "Louisiana")]
        LA,
        [Display(Name = "Massachusetts")]
        MA,
        [Display(Name = "Maryland")]
        MD,
        [Display(Name = "Maine")]
        ME,
        [Display(Name = "Michigan")]
        MI,
        [Display(Name = "Minnesota")]
        MN,
        [Display(Name = "Missouri")]
        MO,
        [Display(Name = "Mississippi")]
        MS,
        [Display(Name = "Montana")]
        MT,
        [Display(Name = "North Carolina")]
        NC,
        [Display(Name = "North Dakota")]
        ND,
        [Display(Name = "Nebraska")]
        NE,
        [Display(Name = "New Hampshire")]
        NH,
        [Display(Name = "New Jersey")]
        NJ,
        [Display(Name = "New Mexico")]
        NM,
        [Display(Name = "Nevada")]
        NV,
        [Display(Name = "New York")]
        NY,
        [Display(Name = "Oklahoma")]
        OK,
        [Display(Name = "Ohio")]
        OH,
        [Display(Name = "Oregon")]
        OR,
        [Display(Name = "Pennsylvania")]
        PA,
        [Display(Name = "Rhode Island")]
        RI,
        [Display(Name = "South Carolina")]
        SC,
        [Display(Name = "South Dakota")]
        SD,
        [Display(Name = "Tennessee")]
        TN,
        [Display(Name = "Texas")]
        TX,
        [Display(Name = "Utah")]
        UT,
        [Display(Name = "Virginia")]
        VA,
        [Display(Name = "Vermont")]
        VT,
        [Display(Name = "Washington")]
        WA,
        [Display(Name = "Wisconsin")]
        WI,
        [Display(Name = "West Virginia")]
        WV,
        [Display(Name = "Wyoming")]
        WY
    }
}
