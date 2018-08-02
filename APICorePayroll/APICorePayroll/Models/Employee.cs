using APICorePayroll.Data_Repository;
using APICorePayroll.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace APICorePayroll.Models
{
    public class Employee : PayrollEntityBase
    {
        #region Personal Tab

        [Required]
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        [Required]
        public string LastName { get; set; }
        public string SocialSecurity { get; set; }
        public DateTime IDExpiryDate { get; set; }
        public DateTime DateofBirth { get; set; }
        public string PlaceofBirth { get; set; }
        public Gender Gender { get; set; }
        public Nationality Nationality { get; set; }
        public MaritalStatus MaritalStatus { get; set; }
        public string PassportNo { get; set; }
        public DateTime IssueDate { get; set; }
        public DateTime ExpiryDate { get; set; }
        public VisaType VisaType { get; set; }
        public DateTime VisaExpiryDate { get; set; }

        #endregion Personal Tab

        #region Dependent Tab

        #endregion Dependent Tab

        #region Contact Details

        public string HouseNo { get; set; }
        public string ProvinceCity { get; set; }

        public string StreetName { get; set; }
        public string Country { get; set; }
        public string Village { get; set; }
        public string PhoneNumber { get; set; }
        public string CommuneSangkat { get; set; }
        public string MobilePhone { get; set; }
        public string DistrictKhan { get; set; }
        public string Fax { get; set; }
        public string Email { get; set; }

        #endregion Contact Details
    }
}