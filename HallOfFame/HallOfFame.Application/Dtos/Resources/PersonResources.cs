namespace HallOfFame.Application.Dtos.Resources
{
    public class PersonResources
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string DisplayName { get; set; }
        public List<SkillResources> Skills { get; set; }
    }
}
