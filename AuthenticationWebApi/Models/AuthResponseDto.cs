namespace AuthenticationWebApi.Models
{
    public class AuthResponseDto
    {
        public bool Success { get; set; } = false;
        public string Message { get; set; } = string.Empty;
        public string Token { get; set; } = string.Empty;
    }
}
