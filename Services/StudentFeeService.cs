using BlazorApp1.Model;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace BlazorApp1.Services
{
    public class StudentFeeService
    {
        private readonly HttpClient _httpClient;

        public StudentFeeService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<StudentFee>> GetStudentFeesAsync()
        {
            return await _httpClient.GetFromJsonAsync<List<StudentFee>>("api/StudentFees");
        }

        public async Task<StudentFee> GetStudentFeeAsync(int id)
        {
            return await _httpClient.GetFromJsonAsync<StudentFee>($"api/StudentFees/{id}")
                   ?? new StudentFee();
        }

        public async Task<HttpResponseMessage> CreateStudentFeeAsync(StudentFee studentFee)
        {
            return await _httpClient.PostAsJsonAsync("api/StudentFees", studentFee);
        }

        public async Task<HttpResponseMessage> UpdateStudentFeeAsync(int id, StudentFee studentFee)
        {
            return await _httpClient.PutAsJsonAsync($"api/StudentFees/{id}", studentFee);
        }

        public async Task<HttpResponseMessage> DeleteStudentFeeAsync(int id)
        {
            return await _httpClient.DeleteAsync($"api/StudentFees/{id}");
        }

        public async Task<FeeSummary> GetStudentFeeSummaryAsync()
        {
            return await _httpClient.GetFromJsonAsync<FeeSummary>("api/StudentFees/Summary")
                   ?? new FeeSummary();
        }

        public async Task<(bool IsSuccess, string Message)> SubmitEditRequestAsync(StudentFeeEditRequest request)
        {
            var response = await _httpClient.PutAsJsonAsync("api/StudentFees/edit-request", request);

            if (response.IsSuccessStatusCode)
            {
                var message = await response.Content.ReadAsStringAsync();
                return (true, message);
            }
            else
            {
                var errorMessage = await response.Content.ReadAsStringAsync();
                return (false, errorMessage);
            }
        }

       
    }
}
