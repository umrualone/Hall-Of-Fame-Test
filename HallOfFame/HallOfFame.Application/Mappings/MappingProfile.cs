using AutoMapper;
using HallOfFame.Application.Dtos.Requests.Person;
using HallOfFame.Application.Dtos.Requests.Skill;
using HallOfFame.Application.Dtos.Resources;
using HallOfFame.Domain.Models;

namespace HallOfFame.Application.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<PersonCreateRequest, Person>();
            CreateMap<Person, PersonResources>();
            CreateMap<SkillCreateRequest, Skill>();
            CreateMap<Skill, SkillResources>();
            CreateMap<PersonUpdateRequest, Person>();
        }
    }
}
