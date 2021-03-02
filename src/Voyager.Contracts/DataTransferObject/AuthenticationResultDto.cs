namespace Voyager.Contracts.DataTransferObject
{
    public sealed record AuthenticationResultDto(string IsSuccess, string Token, string ErrorMessage);
}