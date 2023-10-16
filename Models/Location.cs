﻿using System.ComponentModel;
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
        [Description("Alabama")]
        AL,
        [Description("Alaska")]
        AK,
        [Description("Arkansas")]
        AR,
        [Description("Arizona")]
        AZ,
        [Description("California")]
        CA,
        [Description("Colorado")]
        CO,
        [Description("Connecticut")]
        CT,
        [Description("District of Columbia")]
        DC,
        [Description("Delaware")]
        DE,
        [Description("Florida")]
        FL,
        [Description("Georgia")]
        GA,
        [Description("Hawaii")]
        HI,
        [Description("Iowa")]
        IA,
        [Description("Idaho")]
        ID,
        [Description("Illinois")]
        IL,
        [Description("Indiana")]
        IN,
        [Description("Kansas")]
        KS,
        [Description("Kentucky")]
        KY,
        [Description("Louisiana")]
        LA,
        [Description("Massachusetts")]
        MA,
        [Description("Maryland")]
        MD,
        [Description("Maine")]
        ME,
        [Description("Michigan")]
        MI,
        [Description("Minnesota")]
        MN,
        [Description("Missouri")]
        MO,
        [Description("Mississippi")]
        MS,
        [Description("Montana")]
        MT,
        [Description("North Carolina")]
        NC,
        [Description("North Dakota")]
        ND,
        [Description("Nebraska")]
        NE,
        [Description("New Hampshire")]
        NH,
        [Description("New Jersey")]
        NJ,
        [Description("New Mexico")]
        NM,
        [Description("Nevada")]
        NV,
        [Description("New York")]
        NY,
        [Description("Oklahoma")]
        OK,
        [Description("Ohio")]
        OH,
        [Description("Oregon")]
        OR,
        [Description("Pennsylvania")]
        PA,
        [Description("Rhode Island")]
        RI,
        [Description("South Carolina")]
        SC,
        [Description("South Dakota")]
        SD,
        [Description("Tennessee")]
        TN,
        [Description("Texas")]
        TX,
        [Description("Utah")]
        UT,
        [Description("Virginia")]
        VA,
        [Description("Vermont")]
        VT,
        [Description("Washington")]
        WA,
        [Description("Wisconsin")]
        WI,
        [Description("West Virginia")]
        WV,
        [Description("Wyoming")]
        WY
    }
}
