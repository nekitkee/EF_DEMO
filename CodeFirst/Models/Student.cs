﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CodeFirst.Models
{
    public class Student
    {
        public int StudentID { get; set; }

        [Required(ErrorMessage ="Required")]
        [StringLength(10, MinimumLength =3, ErrorMessage = "Enter minimum 3 characters and maximum 10 character")]
        [RegularExpression(@"(\S)+", ErrorMessage ="White space is not allowed")]
        public string Name { get; set; }
        public string Address { get; set; }
        public string Mobile { get; set; }
    }
}