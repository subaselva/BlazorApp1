using System.ComponentModel.DataAnnotations;


using Microsoft.AspNetCore.Components.Forms;
namespace BlazorApp1.Model
{
    public class Student
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Roll number is required.")]
        [MaxLength(20)]
        public string RollNumber { get; set; } // Global Unique Identifier for Student

        [Required(ErrorMessage = "Name is required.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Gender is required.")]
        public string Gender { get; set; }

        [Required(ErrorMessage = "Date of birth is required.")]
        public DateTime DateOfBirth { get; set; }

        [Required]
        public string PermanentEducationNumber { get; set; }
        [Required]
        public string MotherName { get; set; }
        [Required]
        public string FatherName { get; set; }
        [Required]
        public string GuardianName { get; set; }
        [Required]
        public string AadharNumber { get; set; }
        [Required]
        public string NameOnAadhar { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public string Pincode { get; set; }

        [Required(ErrorMessage = "Mobile number is required.")]
        [RegularExpression(@"^\d{10}$", ErrorMessage = "Mobile number must be exactly 10 digits.")]
        public string MobileNumber { get; set; }

        [Required(ErrorMessage = "Alternate mobile number is required.")]
        [RegularExpression(@"^\d{10}$", ErrorMessage = "Alternate mobile number must be exactly 10 digits.")]
        public string AlternateMobileNumber { get; set; }

        [Required(ErrorMessage = "Email is required.")]
        [EmailAddress(ErrorMessage = "Enter a valid email address.")]
        public string Email { get; set; }

        // Newly Added Fields with Custom Error Messages
        [Required(ErrorMessage = "Mother tongue is required.")]
        public string MotherTongue { get; set; }

        [Required(ErrorMessage = "Social category is required.")]
        public string SocialCategory { get; set; }

        [Required(ErrorMessage = "Minority group is required.")]
        public string MinorityGroup { get; set; }

        [Required(ErrorMessage = "Is BPL Beneficiary field is required.")]
        public string IsBPLBeneficiary { get; set; }

        [Required(ErrorMessage = "Is AAY Beneficiary field is required.")]
        public string IsAAYBeneficiary { get; set; }

        [Required(ErrorMessage = "Is EWS field is required.")]
        public string IsEWS { get; set; }

        [Required(ErrorMessage = "Is CWSN field is required.")]
        public string IsCWSN { get; set; }

        [Required(ErrorMessage = "Type of impairment is required.")]
        public string TypeOfImpairment { get; set; }

        [Required(ErrorMessage = "Is Indian field is required.")]
        public string IsIndian { get; set; }

        [Required(ErrorMessage = "Is Out of School field is required.")]
        public string IsOutOfSchool { get; set; }

        [Required(ErrorMessage = "Disability certificate status is required.")]
        public string HasDisabilityCertificate { get; set; }

        [Required(ErrorMessage = "Disability percentage is required.")]
        public decimal DisabilityPercentage { get; set; }

        [Required(ErrorMessage = "Blood group is required.")]
        public string BloodGroup { get; set; }

        
        [ValidateComplexType]
        public StudentProfile Profile { get; set; } = new StudentProfile();

        
        [ValidateComplexType]
        public EnrollmentDetail Enrollment { get; set; } = new EnrollmentDetail();

    }
}
