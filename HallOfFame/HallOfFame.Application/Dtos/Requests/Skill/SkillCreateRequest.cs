using System.ComponentModel.DataAnnotations;

namespace HallOfFame.Application.Dtos.Requests.Skill
{
    public class SkillCreateRequest
    {
        [Required]
        [Range(1, 10)]
        public byte Level { get; set; }
        [Required]
        [MaxLength(255)]
        public string Name { get; set; }
    }
}
