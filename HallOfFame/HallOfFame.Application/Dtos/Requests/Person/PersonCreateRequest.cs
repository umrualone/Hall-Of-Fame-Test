using HallOfFame.Application.Dtos.Requests.Skill;
using System.ComponentModel.DataAnnotations;

namespace HallOfFame.Application.Dtos.Requests.Person
{
    public class PersonCreateRequest
    {
        [Required]
        [MaxLength(255)]
        public string Name { get; set; }
        [Required]
        [MaxLength(255)]
        public string DisplayName { get; set; }

        [Required]
        public List<SkillCreateRequest> Skills { get; set; }
    }
}
