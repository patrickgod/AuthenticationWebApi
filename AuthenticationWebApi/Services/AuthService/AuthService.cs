namespace AuthenticationWebApi.Services.AuthService
{
    public class AuthService : IAuthService
    {
        public async Task<User> RegisterUser(UserDto request)
        {
            var user = new User { Username = request.Username };
            return user;
        }
    }
}
