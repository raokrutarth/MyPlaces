using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Web.DynamicData;

namespace MyPlaces.Models
{    
    public class Customer
    {
        public long ID { get; set; }

        [Required]
        [StringLength(50,MinimumLength = 3)]
        [Display(Name = "Customer Name")]
        public string CustomerName { get; set; }

        [Required]
        [Range(16,120)]
        [Display(Name = "Age")]
        public int age { get; set; }

        [Required]
        [Display(Name = "Gender")]
        public string gender { get; set; }

        [Required]
        [RegularExpression(@"[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,4}", 
             ErrorMessage = "Email address is not in correct format.")]
        [Display(Name = "Email")]
        public string email { get; set; }

        [Required]
        [Display(Name = "Password")]
        public string password { get; set; }

        [Required]
        [Compare("password")]
        [Display(Name = "Confirm Password")]
        public string confirm_password { get; set; }

        [Required]
        [Display(Name = "Address")]
        public string address { get; set; }

        [Required]
        [RegularExpression(@"[0-9]{3}\-[0-9]{3}\-[0-9]{4}", 
            ErrorMessage = "Enter phone number in format xxx-xxx-xxxx")]
        [Display(Name = "Phone Number")]
        public string phoneNumber { get; set; }

        [Display(Name = "Subscribe to offers and Updates")]
        public bool subscribe { get; set; }
    }
}