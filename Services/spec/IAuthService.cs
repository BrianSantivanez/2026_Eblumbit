using System;
using EBlumbit.DTO.Auth;

namespace EBlumbit.Services.spec;

public interface IAuthService
{
    Task<AuthResponse> Login(AuthRequest request);

    Task<AuthResponse> RefreshToken(RefreshTokenRequest request);
}
