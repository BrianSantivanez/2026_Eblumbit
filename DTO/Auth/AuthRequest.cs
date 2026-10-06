using System;
using System.ComponentModel.DataAnnotations;

namespace EBlumbit.DTO.Auth;

public record class AuthRequest
{
    [Required]  
    [EmailAddress]
    public string Email;  

    [Required]
    public string Password;
}
