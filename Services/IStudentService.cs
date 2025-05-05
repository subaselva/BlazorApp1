using BlazorApp1.Model;

namespace BlazorApp1.Services
{
    public interface IStudentService
    {
        Task<List<Student>> GetStudents();
        Task<Student> GetStudentById(int id);
        Task AddStudent(Student student);

        Task UpdateStudent(Student student);
        Task DeleteStudent(int id);
        Task ExportToExcel();

        Task<List<StudentProfile>> GetAllStudentProfilesAsync();
        Task<StudentProfile> GetProfileByIdAsync(int id);
    }

}
