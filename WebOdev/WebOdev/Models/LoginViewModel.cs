﻿using System.ComponentModel.DataAnnotations;

namespace WebOdev.Models
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Username is required.")]
        [StringLength(30, ErrorMessage = "Username can be max 30 characters.")]
        public string? Username { get; set; }

        [Required(ErrorMessage = "Password is required.")]
        [MinLength(3, ErrorMessage = "Password can be min 3 characters.")]
        [MaxLength(16, ErrorMessage = "Password can be max 16 characters.")]
        public string? Password { get; set; }
    }
}
