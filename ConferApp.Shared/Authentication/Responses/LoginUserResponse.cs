namespace ConferApp.Shared.Authentication.Responses
{
    public record LoginUserResponse(string JwtToken) :  BaseServiceResponse<string>;
}
