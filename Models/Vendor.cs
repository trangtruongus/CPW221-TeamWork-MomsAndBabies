using System.ComponentModel.DataAnnotations;

namespace CPW221_MomsAndBabies.Models
{
    /// <summary>
    /// Represents a Vendor
    /// </summary>
    public class Vendor
    {
        /// <summary> 
        /// The unique identifier for the Vendor
        /// </summary>
        [Key]
        public int VendorID { get; set; }

        /// <summary>
        /// The Vendor's Name
        /// </summary>
        [Display(Name = "Vendor Name")]
        [StringLength(50)]
        [Required(ErrorMessage = "{0} is required.")]
        public string VendorName { get; set; }

        /// <summary>
        /// The Vendor's Phone Number
        /// </summary>
        [Display(Name = "Phone Number")]
        [DataType(DataType.PhoneNumber)]
        [Required(ErrorMessage = "{0} is required.")]
        public string VendorPhoneNumber { get; set; }

        /// <summary>
        /// The Vendor's Email Address
        /// </summary>
        [StringLength(100)]
        [Display(Name = "Vendor's Email")]
        [EmailAddress(ErrorMessage = "Invalid email address.")]
        [Required(ErrorMessage = "{0} is required.")]
        public string VendorEmail { get; set; } 

        /// <summary>
		/// The Vendor's Contact First Name
		/// </summary>
        [Display(Name = "Vendor Contact First Name")]
        [StringLength(50)]
        [Required(ErrorMessage = "{0} is required.")]
        public string VendorContactFirstName { get; set; }

        /// <summary>
		/// The Vendor's Contact Last Name
		/// </summary>
		[Display(Name = "Vendor Contact Last Name")]
        [StringLength(50)]
        [Required(ErrorMessage = "{0} is required.")]
        public string VendorContactLastName { get; set; }

        // Vendor's Address needed?
    }
}
