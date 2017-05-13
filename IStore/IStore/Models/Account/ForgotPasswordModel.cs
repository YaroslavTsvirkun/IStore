using System;
using System.ComponentModel.DataAnnotations;

namespace IStore.Models.Account
{
    /// <summary>
    /// Класс ForgotPasswordModel получает адресс эл. почты для сброса пароля
    /// </summary>
    public class ForgotPasswordModel
    {
        [Required]
        [EmailAddress]
        [Display(Name = "Почта")]
        public String Email { get; set; }
    }
}