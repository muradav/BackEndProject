﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AllupProject.Models
{
    public class Subscription
    {
        public int Id { get; set; }

        [Required, EmailAddress]
        public string Email { get; set; }
    }
}