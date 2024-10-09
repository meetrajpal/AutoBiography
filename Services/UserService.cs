using AutoBiography.Models;
using Microsoft.AspNetCore.Identity;

namespace AutoBiography.Services;
public class UserService
{
    private readonly PasswordHasher<UserProfile> _passwordHasher;

    public UserService()
    {
        _passwordHasher = new PasswordHasher<UserProfile>();
    }

    public string HashPassword(UserProfile user, string password)
    {
        return _passwordHasher.HashPassword(user, password);
    }

    public bool VerifyPassword(UserProfile user, string hashedPassword, string providedPassword)
    {
        var result = _passwordHasher.VerifyHashedPassword(user, hashedPassword, providedPassword);
        return result == PasswordVerificationResult.Success;
    }
}