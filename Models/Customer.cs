using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq.Expressions;
using System.Xml.Linq;

namespace CPW221_MomsAndBabies.Models
{
    /// <summary>
    /// Represents a Customer
    /// </summary>
    public class Customer
    {
        /// <summary> 
        /// The unique identifier for the Customer
        /// </summary>
        [Key]
        public int CustomerID { get; set; }

        /// <summary>
		/// The Customer's First Name
		/// </summary>
        [Display(Name = "First Name")]
        [StringLength(50)]
        [Required(ErrorMessage = "{0} is required.")]
        public string FirstName { get; set; }

        /// <summary>
        /// The Customer's Middle Name
        /// </summary>
        [StringLength(50)]
        [Display(Name = "Middle Name")]
        public string? MiddleName { get; set; }

        /// <summary>
		/// The Customer's Last Name
		/// </summary>
		[Display(Name = "Last Name")]
        [StringLength(50)]
        [Required(ErrorMessage = "{0} is required.")]
        public string LastName { get; set; }

        /// <summary>
        /// The Customer's Date Of Birth
        /// </summary>
        [Display(Name = "Date Of Birth")]
        [DataType(DataType.Date)]
        [Required(ErrorMessage = "{0} is required.")]
        public DateTime DateOfBirth { get; set; }

        /// <summary>
        /// The Customer's Gender
        /// </summary>
        [Display(Name = "Gender")]
        [Required(ErrorMessage = "{0} is required.")]
        public string Gender { get; set; }

        /// <summary>
        /// The Customer's Phone Number
        /// </summary>
        [Display(Name = "Phone Number")]
        [DataType(DataType.PhoneNumber)]
        [Required(ErrorMessage = "{0} is required.")]
        public string PhoneNumber { get; set; }

        /// <summary>
        /// The Customer's Email Address
        /// </summary>
        [StringLength(100)]
        [Display(Name = "Email")]
        [EmailAddress(ErrorMessage = "Invalid email address.")]
        //[Required(ErrorMessage = "{0} is required.")]
        public string? Email { get; set; } // Should be required?

        // Customer's Address needed?

        public List<SelectListItem> GetGenderSelectList()
        {
            return new List<SelectListItem>
            {
                new SelectListItem { Value = "Male", Text = "Male" },
                new SelectListItem { Value = "Female", Text = "Female" },
                new SelectListItem { Value = "Other", Text = "Other" },
                new SelectListItem { Value = "PreferNotToSay", Text = "Prefer Not To Say" }
            };
        }
    }

    

    /*
    public enum Gender
    {
        [Display(Name = "Male")]
        Male = 1,
        [Display(Name = "Female")]
        Female = 2,
        [Display(Name = "Other")]
        Other = 3,
        [Display(Name = "Prefer Not To Say")]
        PreferNotToSay = 4
    }
    */
}
