namespace ConferApp.Shared.Authentication.Responses
{
    public abstract record BaseServiceResponse<ResponseType>(bool Success = false,
        string? Message = null, ResponseType? Data = default);
}
