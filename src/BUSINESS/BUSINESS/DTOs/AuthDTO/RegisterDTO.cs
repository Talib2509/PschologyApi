using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PsychologyApi.Business.DTOs.AuthDTO;

public class RegisterDTO
{
    [Required, MaxLength(100)]
    public string FirstName { get; set; } = string.Empty;
    [Required, MaxLength(100)]
    public string LastName { get; set; } = string.Empty;

    [Required, EmailAddress]
    public string Email { get; set; } = string.Empty;
    [Required, Phone]
    public string PhoneNumber { get; set; } = string.Empty;
    [Required, MinLength(5)]
    public string Password { get; set; } = string.Empty;
    [Required, Compare("Password")]
    public string ConfirmPassword { get; set; } = string.Empty;
}
