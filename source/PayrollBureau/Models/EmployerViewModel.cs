﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using PayrollBureau.Data.Entities;

namespace PayrollBureau.Models
{
    public class EmployerViewModel : BaseViewModel
    {
        public Employer Employer { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }

    }
}