using VillaApi.models;

namespace VillaApi.models.Dto.User
{
    public class LoginResponseDTO
    {
        public LocalUser User { get; set; }
        public string Token { get; set; }
    }
}
