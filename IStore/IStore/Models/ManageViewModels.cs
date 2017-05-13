using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNet.Identity;
using Microsoft.Owin.Security;
using System;

namespace IStore.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class IndexViewModel
    {
        public Boolean HasPassword { get; set; }
        public IList<UserLoginInfo> Logins { get; set; }
        public String PhoneNumber { get; set; }
        public Boolean TwoFactor { get; set; }
        public Boolean BrowserRemembered { get; set; }
    }

    /// <summary>
    /// 
    /// </summary>
    public class ManageLoginsViewModel
    {
        public IList<UserLoginInfo> CurrentLogins { get; set; }
        public IList<AuthenticationDescription> OtherLogins { get; set; }
    }

    /// <summary>
    /// 
    /// </summary>
    public class FactorViewModel
    {
        public String Purpose { get; set; }
    }

    /// <summary>
    /// 
    /// </summary>
    public class SetPasswordViewModel
    {
        [Required]
        [StringLength(50, ErrorMessage = "Значение {0} должно содержать символов не менее: {2}.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Новый пароль")]
        public String NewPassword { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Подтверждение нового пароля")]
        [Compare("NewPassword", ErrorMessage = "Новый пароль и его подтверждение не совпадают.")]
        public String ConfirmPassword { get; set; }
    }

    /// <summary>
    /// 
    /// </summary>
    public class ChangePasswordViewModel
    {
        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Текущий пароль")]
        public String OldPassword { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "Значение {0} должно содержать символов не менее: {2}.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Новый пароль")]
        public String NewPassword { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Подтверждение нового пароля")]
        [Compare("NewPassword", ErrorMessage = "Новый пароль и его подтверждение не совпадают.")]
        public String ConfirmPassword { get; set; }
    }

    /// <summary>
    /// 
    /// </summary>
    public class ConfigureTwoFactorViewModel
    {
        public String SelectedProvider { get; set; }
        public ICollection<System.Web.Mvc.SelectListItem> Providers { get; set; }
    }
}