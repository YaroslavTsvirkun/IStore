using System.ComponentModel.DataAnnotations;

namespace IStore.Models.Manage
{
    /// <summary>
    /// Класс VerifyPhoneNumberModel инициализирует верификацию номера телефона
    /// </summary>
    public class VerifyPhoneNumberModel
    {
        [Required]
        [Display(Name = "Код")]
        public string Code { get; set; }

        [Required]
        [Phone]
        [Display(Name = "Номер телефона")]
        public string PhoneNumber { get; set; }
    }
}