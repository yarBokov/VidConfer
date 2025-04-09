namespace ConferApp.Shared
{
    public abstract record BaseServiceResponse<ResponseType>(bool Success = false,
        string? Message = null, ResponseType? Data = default);
}
