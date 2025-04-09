namespace ConferApp.Shared.Meetings.Requests
{
    public record PutDetailsInConnectionUuidRequest(string ConnectionUuid, string UserId, string Name);
}
