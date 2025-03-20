namespace HallOfFame.Domain.Models
{
    public class Person: BaseModel
    {
        public string Name { get; set; }
        public string DisplayName {  get; set; }
        public List<Skill> Skills { get; set; }

        public Person(string name, string displayName)
        {
            Name = name;
            DisplayName = displayName;
            Skills = new List<Skill>(); // Инициализация списка
        }
    }
}
