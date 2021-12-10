using System.ComponentModel.DataAnnotations;

namespace MyCompany.Domain.Entities
{
    public class NewsItem: EntityBase
    {
        
        [Required(ErrorMessage = "Заполните название новости")]
        [Display(Name = "Название новости")]
        public override string Title { get; set; }

        [Display(Name = "Краткое содержание новости")]
        public override string Subtitle { get; set; }

        [Display(Name = "Полное содержание новости")]
        public override string Text { get; set; }

        [Display(Name = "Ваш email для получения обратной связи")]
        public string Author { get; set; }

        public bool IsApproved { get; set; }
    }

}
