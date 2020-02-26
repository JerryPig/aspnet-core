using System.ComponentModel.DataAnnotations;

namespace ZCms.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}