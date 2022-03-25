using System.ComponentModel.DataAnnotations;

namespace MyCompany.Domain.Entities
{
    public class ServiceItem : EntityBase
    {
        [Required(ErrorMessage = "Заполните название услуги")]
        [Display(Name = "Новости")]
        public override string Title { get; set; }

        [Display(Name = "Краткое описание")]
        public override string Subtitle { get; set; }

        [Display(Name = "Полное описание")]
        public override string Text { get; set; }
    }
}
