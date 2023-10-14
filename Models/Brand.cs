using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace CPW221_MomsAndBabies.Models
{
    /// <summary>
    /// Represents a Brand
    /// </summary>
    public class Brand
    {
        /// <summary> 
        /// The unique identifier for the Brand
        /// </summary>
        [Key]
        public int BrandID { get; set; }

        /// <summary>
		/// The Brand Name
		/// </summary>
        [Display(Name = "Brand Name")]
        [StringLength(50)]
        [Required(ErrorMessage = "{0} is required.")]
        public string BrandName { get; set; }

        /// <summary>
        /// The Brand's Description
        /// </summary>
        [Display(Name = "Description")]
        [StringLength(250)]
        public string? Description { get; set; }
    }
}
