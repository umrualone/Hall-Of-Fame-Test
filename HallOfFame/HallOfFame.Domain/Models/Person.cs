namespace HallOfFame.Domain.Models
{
    public class Person: BaseModel
    {
        public string Name { get; set; }
        public string DisplayName {  get; set; }
        public List<Skill> Skills { get; set; }
    }
}
