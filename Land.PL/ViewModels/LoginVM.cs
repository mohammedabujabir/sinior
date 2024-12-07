﻿using System.ComponentModel.DataAnnotations;

namespace Land.PL.ViewModels
{
    public class LoginVM
    {



        [Required(ErrorMessage = "email is required...")]
        [MinLength(5)]
        [DataType(DataType.EmailAddress)]

        public string Email { get; set; }

        [Required(ErrorMessage = "password is required...")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        public bool RememberMe { get; set; }

      
    }
}
