using System;
using System.ComponentModel.DataAnnotations;

namespace IStore.Models.Account
{
    /// <summary>
    ///  Класс LoginModel предоставляет логику для авторизации пользувателя
    /// </summary>
    public class LoginModel
    {
        [Required]
        [Display(Name = "Адрес электронной почты")]
        [EmailAddress]
        public String Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Пароль")]
        public String Password { get; set; }

        [Display(Name = "Запомнить меня")]
        public Boolean RememberMe { get; set; }
    }
}