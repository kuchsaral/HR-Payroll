using System.ComponentModel.DataAnnotations;

namespace APICorePayroll.Enum
{
    public enum UserStatus
    {
        [Display(Name = "Inactivate")]
        Inactivate = 0,
        [Display(Name = "Activated")]
        Activated = 1,
        [Display(Name = "Preview")]
        Preview = 2,
        [Display(Name = "Waiting Admin Confirm")]
        WaitingAdminConfirm = 3,
        [Display(Name = "Reactivate")]
        Reactivate = 4
    }
}