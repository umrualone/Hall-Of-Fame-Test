using HallOfFame.Application.Dtos.Requests.Skill;
using System.ComponentModel.DataAnnotations;

namespace HallOfFame.Application.Dtos.Requests.Person
{
    public class PersonUpdateRequest
    {
        [MaxLength(255)]
        public string? Name { get; set; }
        [MaxLength(255)]
        public string? DisplayName { get; set; }
        public List<SkillCreateRequest>? Skills { get; set; }
    }
}
