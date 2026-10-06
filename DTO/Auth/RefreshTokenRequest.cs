using System.ComponentModel.DataAnnotations;

namespace EBlumbit.DTO.Auth;

public record class RefreshTokenRequest
{
    [Required]
    public string RefreshToken;
}
