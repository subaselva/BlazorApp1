namespace BlazorApp1.Model
{
    public class DeleteRequestDto
    {
        public int Id { get; set; }
        public int StudentFeeId { get; set; }
        public string StudentName { get; set; }
        public string RequestedBy { get; set; }
        public DateTime RequestedAt { get; set; }
    }

}
