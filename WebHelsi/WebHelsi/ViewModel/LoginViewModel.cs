using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebHelsi.ViewModels
{
    public class LoginViewModel
    {
        [EmailAddress(ErrorMessage = "Невірно введені дані!")]
        [Required(ErrorMessage = "Поле не може бути пустим!")]
        public string Email { get; set; }
       
        [Required(ErrorMessage = "Поле не може бути пустим!")]
        public string Password { get; set; }
    }

    public class RegistrationClientVM
    {
        [Required(ErrorMessage = "Поле Ім'я не може бути порожнім")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Поле Прізвище не може бути порожнім")]
        public string Surname { get; set; }

        [Required(ErrorMessage = "Поле Дата народження не може бути порожнім")]
        public DateTime DateTime { get; set; }

        [EmailAddress(ErrorMessage = "Має бути пошта!")]
        [Required(ErrorMessage = "Поле Email не може бути порожнім")]
        public string Email { get; set; }

        [RegularExpression(@"^(?=.*\d)(?=.*[a-z])(?=.*[A-Z])(?!.*\s).{6,24}$",
            ErrorMessage = "Пароль більше 6 символів і містити цифру, велику і малу літеру")]
        [Required(ErrorMessage = "Поле Пароль не може бути порожнім")]
        public string Password { get; set; }

        //[RegularExpression(@"^[+]\d{12}$",
        //    ErrorMessage = "В телефоні має бути 12 цифр")]
        //[Required(ErrorMessage = "Поле Phone не може бути порожнім")]
        //// public string Phone { get; set; }
    }
}
