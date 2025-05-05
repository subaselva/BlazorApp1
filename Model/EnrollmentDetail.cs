using System.ComponentModel.DataAnnotations;

namespace BlazorApp1.Model
{
    public class EnrollmentDetail
    {
        [Key]
        public int Id { get; set; }
        public int StudentId { get; set; } // Foreign Key
        
        [Required(ErrorMessage = "Admission number is required")]
        public int AdmissionNumber { get; set; }

        [Required(ErrorMessage = "Admission date is required")]
        public DateTime AdmissionDate { get; set; }

        [Required(ErrorMessage = "Class Roll Number is required")]
        public int ClassRollNo { get; set; }

        [Required(ErrorMessage = "Medium of Instruction is required")]
        public string MediumOfInstruction { get; set; }

        [Required(ErrorMessage = "Languages Group Studied is required")]
        public string LanguagesGroupStudied { get; set; }

        [Required(ErrorMessage = "Academic Group Studied is required")]
        public string AcademicGroupStudied { get; set; }

        [Required(ErrorMessage = "Subjects Group Studied is required")]
        public string SubjectsGroupStudied { get; set; }

        [Required(ErrorMessage = "Previous Academic Year is required")]
        public string PreviousAcademicYear { get; set; }

        [Required(ErrorMessage = "Status of Previous Year is required")]
        public string StatusPreviousYear { get; set; }

        [Required(ErrorMessage = "Admitted status is required")]
        public string Admitted { get; set; }

        [Required(ErrorMessage = "Previous Class is required")]
        public string PreviousClass { get; set; }

        [Required(ErrorMessage = "Marks are required")]
        public string Marks { get; set; }

        [Required(ErrorMessage = "Previous Attendance is required")]
        public string PreviousAttendance { get; set; }

    }

}
