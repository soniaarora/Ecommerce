using Web.Models;

namespace Web.IService
{
    public interface IAuthService
    {
        Task<ResponseDto?> RegisterAsync(RegistrationRequestDto registrationRequestDto);
        Task<ResponseDto?> LoginAsync(LoginRequestDto loginRequestDto);
        Task<ResponseDto?> AssignRoleAsync(RegistrationRequestDto registerRequestDto);
 
    }
}
