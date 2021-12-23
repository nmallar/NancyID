using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NancyWebsite.Models
{
    public class ContactViewModel
    {

        //[StringLength(20, MinimumLength = 5)]
        //[Required(ErrorMessage = "Name field is requied")]
        public string Name { get; set; }
        // [Required(ErrorMessage = "Email field is requied")]
        // [EmailAddress]
        public string Email { get; set; }
        //[Required(ErrorMessage = "Subject field is requied")]
        public string Subject { get; set; }
        // [Required(ErrorMessage = "Message field is requied")]
        public string Message { get; set; }
        public string Phone { get; set; }
        public bool IsEnquiry { get; set; }
    }
}