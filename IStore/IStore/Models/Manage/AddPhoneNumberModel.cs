using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace IStore.Models.Manage
{
    /// <summary>
    /// Класс AddPhoneNumberModel инициализирует номер телефона
    /// </summary>
    public class AddPhoneNumberModel
    {
        [Required]
        [Phone]
        [StringLength(17, ErrorMessage = "Значение {0} должно содержать не менее {2} символов.", MinimumLength = 13)]
        [Display(Name = "Номер телефона")]
        public string Number { get; set; }
    }
}