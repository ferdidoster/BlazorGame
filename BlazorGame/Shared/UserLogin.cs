﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorGame.Shared
{
    public class UserLogin
    {
        [Required(ErrorMessage = "Please enter a username.")]
        public string Username { get; set; }
        [Required(ErrorMessage = "Please enter a Password.")]
        public string Password { get; set; }
    }
}
