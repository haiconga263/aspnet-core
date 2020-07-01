using System.ComponentModel.DataAnnotations;

namespace DEM.Project.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}