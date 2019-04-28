using System.ComponentModel.DataAnnotations;

namespace DG.ERM.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}