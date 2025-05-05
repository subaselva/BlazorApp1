using System.ComponentModel.DataAnnotations;

namespace BlazorApp1.Model
{
    public class StudentProfile
    {
        [Key]
        public int Id { get; set; }

        public int StudentId { get; set; } // Foreign Key
        [Required(ErrorMessage = "Student Name is required")]
        public string StudentName { get; set; }

        [Required(ErrorMessage = "Facilities Provided is required")]
        public string FacilitiesProvided { get; set; }

        [Required(ErrorMessage = "CWSN status is required")]
        public string IsCWSN { get; set; }

        [Required(ErrorMessage = "SLD status is required")]
        public string IsSLD { get; set; }

        [Required(ErrorMessage = "SLD Type is required")]
        public string SLDType { get; set; }

        [Required(ErrorMessage = "ASD status is required")]
        public string IsASD { get; set; }

        [Required(ErrorMessage = "ADHD status is required")]
        public string IsADHD { get; set; }

        [Required(ErrorMessage = "Gifted status is required")]
        public string IsGifted { get; set; }

        [Required(ErrorMessage = "State Competition status is required")]
        public string IsInStateCompetition { get; set; }

        [Required(ErrorMessage = "NCC/NSS status is required")]
        public string IsInNCC_NSS { get; set; }

        [Required(ErrorMessage = "Internet usage status is required")]
        public string IsInUseInternet { get; set; }

        [Required(ErrorMessage = "Height is required")]
        public string Height { get; set; }

        [Required(ErrorMessage = "Weight is required")]
        public string Weight { get; set; }

        [Required(ErrorMessage = "Distance from residence to school is required")]
        public string Residencetoschool { get; set; }

        [Required(ErrorMessage = "Education in family is required")]
        public string Educationinfamily { get; set; }
    }
}
