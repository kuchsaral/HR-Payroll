using APICorePayroll.Enum;
using Microsoft.AspNetCore.Identity;
using System;

namespace APICorePayroll.Models
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class ApplicationUser : IdentityUser<Guid>
    {
        public virtual int ZipCode { get; set; }
        public virtual string CountryCode { get; set; }
        public virtual string CountryName { get; set; }
        public virtual string CardID { get; set; }

        public string ImageIDCard { get; set; }
        public string ProfileImage { get; set; }
        public string CoverImage { get; set; }

        public string FullName { get; set; }
        public string ContactAddress { get; set; }

        public UserStatus Status { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public UserType UserType { get; set; }

    }
}
