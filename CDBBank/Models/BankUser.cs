﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CDBBank.Models
{
    public enum SecurityQues { Favmovie, Favbook }

    public enum AccountType { Savings, Salary }
    public class BankUser
    {
        [Key]
        public int Id { get; set; }

        public string Username { get; set; }

        [Display(Name = "Account Number")]
        [RegularExpression("^[C][D][B]00[D][F][0-9]{4}$", ErrorMessage = "Not a valid Account number")] public string AccountNum { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Your must provide a Mobile Number")]
        [RegularExpression(@"^[789]\d{9}$", ErrorMessage = "Not a valid Mobile number")]
        public long Mobile { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "Check the instructions to create password.", MinimumLength = 8)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }



        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare("Password", ErrorMessage = "Password does not match.")]
        public string ConfirmPassword { get; set; }



        [Display(Name = "Balance")]
        public Double? Balance { get; set; }

        public string Country { get; set; }

        public AccountType AccountType { get; set; }

        public int PinCode { get; set; }

        [Display(Name = "Security Question")]
        public SecurityQues Sques { get; set; }

        [Display(Name = "Security Answer")]
        public string SAns { get; set; }



        [Display(Name = "Date Of Birth")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime DoB { get; set; }
    }
     
}
