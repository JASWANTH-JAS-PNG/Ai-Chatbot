using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace backend.DTOs
{
    public class RegisterDTO
    {
        [Required]
        [MinLength(3, ErrorMessage = "Username must be at least 3 characters long.")]
        [MaxLength(20, ErrorMessage = "Username cannot be longer than 20 characters.")]
        public required string Username { get; set; }
        
        [Required]
        [MinLength(6, ErrorMessage = "Password must be at least 6 characters long.")]
        [MaxLength(100, ErrorMessage = "Password cannot be longer than 100 characters.")]
        public required string Password { get; set; }
        
        [Required]
         [MinLength(6, ErrorMessage = "Confirm Password must be at least 6 characters long.")]
         [MaxLength(100, ErrorMessage = "Confirm Password cannot be longer than 100 characters.")]
         [Compare("Password", ErrorMessage = "Passwords do not match.")]
        public required string ConfirmPassword { get; set; }
        
        [Required]
        [EmailAddress(ErrorMessage = "Invalid email address.")]
        [MaxLength(100, ErrorMessage = "Email cannot be longer than 100 characters.")]
        [MinLength(5, ErrorMessage = "Email must be at least 5 characters long.")]  
        public required string Email { get; set; }

        [Required]
        [MaxLength(50, ErrorMessage = "First Name cannot be longer than 50 characters.")]
        [MinLength(2, ErrorMessage = "First Name must be at least 2 characters long.")]
        public required string FirstName { get; set; }
        
        [MaxLength(50, ErrorMessage = "Last Name cannot be longer than 50 characters.")]
        [MinLength(2, ErrorMessage = "Last Name must be at least 2 characters long.")]
        [Required]
        public required string LastName { get; set; }
    }
}