using System.ComponentModel.DataAnnotations;

namespace Assign1.Models
{
    public class Student
    {
        [Key, Required]
        public int StudentId { get; set; }

        [Display(Name = "First Name"), MaxLength(40), Required]
        public string FirstName { get; set; }

        [Display(Name = "Last Name"), MaxLength(40), Required]
        public string LastName { get; set; }

        [Display(Name = "Mobile Number"), MaxLength(15)]
        public string MobileNumber { get; set; }

        [Display(Name = "Email Address"), MaxLength(200)]
        public string EmailAddress { get; set; }

        [Display(Name = "City of Residence"), MaxLength(25)]
        public string CityOfResidence { get; set; }

        [MaxLength(25)]
        public string Specialization { get; set; }
    }
}
