using System;
using System.ComponentModel.DataAnnotations;

namespace ManagerMVC.Domain.Entities
{
    public class ServiceItem
    {
        [Required]
        public Guid Id { get; set; }

        [Display(Name = "Титульная картинка")]
        public string TitleImagePath { get; set; }

        [Required(ErrorMessage = "Заповніть назву послуги")]
        [Display(Name = "Назва послуги")]
        public string Title { get; set; }

        [Display(Name = "Короткий опис послуги")]
        public string Subtitle { get; set; }

        [Display(Name = "Повний опис послуги")]
        public string Text { get; set; }

        [Display(Name = "Ціна")]
        public int Price { get; set; }

    }
}
