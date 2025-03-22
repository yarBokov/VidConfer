namespace ConferApp.Shared.Meetings.Requests
{
    public class CreateMeetingRequest
    {
        public string HostId {  get; set; } = string.Empty;
        public string Title {  get; set; } = string.Empty;
        public string Description {  get; set; } = string.Empty;
        public string StartTime {  get; set; } = string.Empty;
        public string EndTime {  get; set; } = string.Empty;
        public string StartDate {  get; set; } = string.Empty;
        public string EndDate { get; set; } = string.Empty;
    }
}
