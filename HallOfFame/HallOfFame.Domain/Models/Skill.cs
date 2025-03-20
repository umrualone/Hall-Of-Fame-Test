namespace HallOfFame.Domain.Models
{
    public class Skill: BaseModel
    {
        public string Name { get; set; }
        public byte Level { get; set; }
        public List<Person> Persons { get; set; }

        public Skill(string name)
        {
            Name = name;
            Persons = new List<Person>(); // Инициализация списка
        }
    }
}
