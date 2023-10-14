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
        [StringLength(100)]
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
        Alabama,
        Alaska,
        Arizona,
        Arkansas,
        California,
        Colorado,
        Connecticut,
        Delaware,
        Florida,
        Georgia,
        Hawaii,
        Idaho,
        Illinois,
        Indiana,
        Iowa,
        Kansas,
        Kentucky,
        Louisiana,
        Maine,
        Maryland,
        Massachusetts,
        Michigan,
        Minnesota,
        Mississippi,
        Missouri,
        Montana,
        Nebraska,
        Nevada,
        NewHampshire,
        NewJersey,
        NewMexico,
        NewYork,
        NorthCarolina,
        NorthDakota,
        Ohio,
        Oklahoma,
        Oregon,
        Pennsylvania,
        RhodeIsland,
        SouthCarolina,
        SouthDakota,
        Tennessee,
        Texas,
        Utah,
        Vermont,
        Virginia,
        Washington,
        WestVirginia,
        Wisconsin,
        Wyoming
    }
}
