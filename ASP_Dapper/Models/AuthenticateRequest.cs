﻿using System.ComponentModel.DataAnnotations;

namespace ASP_Dapper.Models
{
    public class AuthenticateRequest
    {
        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; } = string.Empty;
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; } = string.Empty;
    }
}
