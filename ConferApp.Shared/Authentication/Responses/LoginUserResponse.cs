namespace ConferApp.Shared.Authentication.Responses
{
    public record LoginUserResponse(string AccessToken, string RefreshToken) : 
        BaseServiceResponse<string>;
}
