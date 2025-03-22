namespace ConferApp.Shared.Meetings.Responses
{
    public class GetMeeting
    {
        public int Id { get; set; }
        public string MeetingId { get; set; } = string.Empty;
        public string Passcode { get; set; } = string.Empty;
        public string HostId { get; set; } = string.Empty;
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string StartTime { get; set; } = string.Empty;
        public string EndTime { get; set; } = string.Empty;
        public string StartDate { get; set; } = string.Empty;
        public string EndDate { get; set; } = string.Empty;
        public string Link { get; set; } = string.Empty;
    }
}
