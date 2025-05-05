using BlazorApp1.Model;
using System.Net.Http;
using System.Net.Http.Json;

namespace BlazorApp1.Services
{
    public class StudentService : IStudentService
    {
        private readonly HttpClient _http;

        public StudentService(HttpClient http) => _http = http;

        public async Task<List<Student>> GetStudents() =>
            await _http.GetFromJsonAsync<List<Student>>("api/Students/all");

        public async Task<Student> GetStudentById(int id) =>
            await _http.GetFromJsonAsync<Student>($"api/Students/get/{id}");

        public async Task AddStudent(Student student) =>
            await _http.PostAsJsonAsync("api/students/admin/add", student);

        public async Task UpdateStudent(Student student) =>
            await _http.PutAsJsonAsync($"api/Students/edit/{student.Id}", student);

        public async Task DeleteStudent(int id) =>
            await _http.DeleteAsync($"api/Students/delete/{id}");

        public async Task ExportToExcel() =>
            await _http.GetAsync("api/students/export/excel");

        public async Task<List<StudentProfile>> GetAllStudentProfilesAsync()
        {
            var response = await _http.GetFromJsonAsync<List<StudentProfile>>("api/StudentProfile/all");
            return response ?? new List<StudentProfile>();
        }

        // Method to get a specific student profile by ID
        public async Task<StudentProfile> GetProfileByIdAsync(int id)
        {
            var response = await _http.GetFromJsonAsync<StudentProfile>($"api/StudentProfile/get/{id}");
            return response;
        }


    }

}
