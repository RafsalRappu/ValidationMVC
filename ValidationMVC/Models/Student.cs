using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ValidationMVC.Models
{
    public class Student
    {

        [Required(ErrorMessage = "Enter your Name"),MinLength(3), MaxLength(10)]
        public string Name { get; set; }

        [Required(ErrorMessage = "Enter your marks")]
        [StringLength(2,ErrorMessage ="Mark should be less than hundred")]
        public string Marks { get; set; }

        [Required(ErrorMessage = "Type a valid password")]
        [DataType(DataType.Password)]
        [StringLength(4, ErrorMessage = "Password should not be more than 4 ")]
        public string Password { get; set; }

        [Required(ErrorMessage ="Confirm your password")]
        [DataType(DataType.Password)]
        [Compare("Password",ErrorMessage ="Not match")]
        public string ConfirmPassword { get; set; }
    }
   
}