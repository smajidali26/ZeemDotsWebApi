using System.ComponentModel.DataAnnotations;

namespace ZeemDots.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}