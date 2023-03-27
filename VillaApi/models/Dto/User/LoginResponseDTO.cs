using VillaApi.models;

namespace VillaApi.models.Dto.User
{
    public class LoginResponseDTO
    {
        public UserDTO User { get; set; }
        public string Token { get; set; }
    }
}
