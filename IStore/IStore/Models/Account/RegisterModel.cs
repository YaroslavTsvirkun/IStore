using System;
using System.ComponentModel.DataAnnotations;

namespace IStore.Models.Account
{
    /// <summary>
    /// Класс RegisterViewModel предоставляет логику для регистрации пользувателя
    /// </summary>
    public class RegisterModel
    {
        /// <summary>
        /// Свойство Email хранит адрес эл. почты пользувателя
        /// </summary>
        [Required]
        [EmailAddress]
        [Display(Name = "Адрес электронной почты")]
        public string Email { get; set; }

        // [Required]
        // [Display(Name = "Имя")]
        // public String FirstName { get; set; }
        // 
        // [Required]
        // [Display(Name = "Фамилия")]
        // public String LastName { get; set; }
        // 
        // [Required]
        // [StringLength(18, ErrorMessage = "Значение {0} должно содержать не менее {2} символов.", MinimumLength = 13)]
        // [Display(Name = "Номер телефона")]
        // public String Phone { get; set; }

        /// <summary>
        /// Свойство Password хранит пароль пользувателя
        /// </summary>
        [Required]
        [StringLength(50, ErrorMessage = "Значение {0} должно содержать не менее {2} символов.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Пароль")]
        public String Password { get; set; }

        /// <summary>
        /// Свойство ConfirmPassword подтверждает пароль пользувателя
        /// </summary>
        [DataType(DataType.Password)]
        [Display(Name = "Подтверждение пароля")]
        [Compare("Password", ErrorMessage = "Пароль и его подтверждение не совпадают.")]
        public String ConfirmPassword { get; set; }
    }
}