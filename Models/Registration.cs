﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace okta_dotnetcore_react_example.Models
{
    public class Registration
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}