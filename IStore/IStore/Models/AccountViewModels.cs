using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace IStore.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class ExternalLoginConfirmationViewModel
    {
        /// <summary>
        /// 
        /// </summary>
        [Required]
        [Display(Name = "Адрес электронной почты")]
        public String Email { get; set; }
    }

    /// <summary>
    /// 
    /// </summary>
    public class SendCodeViewModel
    {
        /// <summary>
        /// 
        /// </summary>
        public String SelectedProvider { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public ICollection<System.Web.Mvc.SelectListItem> Providers { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public String ReturnUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Boolean RememberMe { get; set; }
    }

    /// <summary>
    /// 
    /// </summary>
    public class VerifyCodeViewModel
    {
        /// <summary>
        /// 
        /// </summary>
        [Required]
        public String Provider { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [Required]
        [Display(Name = "Код")]
        public String Code { get; set; }
        public String ReturnUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [Display(Name = "Запомнить браузер?")]
        public Boolean RememberBrowser { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Boolean RememberMe { get; set; }
    }

    /// <summary>
    /// 
    /// </summary>
    public class ForgotViewModel
    {
        /// <summary>
        /// 
        /// </summary>
        [Required]
        [Display(Name = "Адрес электронной почты")]
        public String Email { get; set; }
    }

    /// <summary>
    /// 
    /// </summary>
    public class ResetPasswordViewModel
    {
        /// <summary>
        /// 
        /// </summary>
        [Required]
        [EmailAddress]
        [Display(Name = "Адрес электронной почты")]
        public String Email { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [Required]
        [StringLength(50, ErrorMessage = "Значение {0} должно содержать не менее {2} символов.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Пароль")]
        public String Password { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [DataType(DataType.Password)]
        [Display(Name = "Подтверждение пароля")]
        [Compare("Password", ErrorMessage = "Пароль и его подтверждение не совпадают.")]
        public String ConfirmPassword { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public String Code { get; set; }
    }
}