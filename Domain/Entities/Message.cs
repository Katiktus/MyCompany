using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyCompany.Domain.Entities
{
    public class Message : EntityBase
    {
        [Required(ErrorMessage = "Заполните тему письма")]
        [Display(Name = "Тема письма")]
        public override string Title { get; set; }

        [Display(Name = "Письмо")]
        public override string Text { get; set; }

        [Display(Name = "Ваш email для получения обратной связи")]
        [Required(ErrorMessage = "Введите email")]
        [EmailAddress(ErrorMessage = "Неправильный email")]
        public string From { get; set; }
    }
}
