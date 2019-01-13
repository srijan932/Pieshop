﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace PieShop.Models
{
    public class Feedback
    {
        [BindNever]
        public int FeedbackId { get; set; }

        [Required]
        [StringLength(100,ErrorMessage="Your name is required")]

        public string Name { get; set; }

        [Required]
        [StringLength(100,ErrorMessage="Your email is required")]
        [DataType(DataType.EmailAddress)]
        
        public string Email { get; set; }

        [Required]
        [StringLength(5000,ErrorMessage ="Your message is required")]

        public string Message { get; set; }

        public bool ContactMe { get; set; }
    }
}
